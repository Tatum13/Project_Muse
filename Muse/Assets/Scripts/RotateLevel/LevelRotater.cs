using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelRotater : MonoBehaviour
{
    public FPControl.PlayerControlsActions inputControls;
    public InputParse input;
    public bool isTurning;
    [SerializeField] private GameObject world;
    public Dictionary<Vector3, Vector3> directions = new Dictionary<Vector3, Vector3>();
    private PlayerGravity _gravity;
    private Vector3 _currentRotation;
    private IEnumerator _routine;

    private void Start()
    {
        world = GameObject.Find("RotateSpot");
        _gravity = GameObject.Find("Player").GetComponent<PlayerGravity>();
        AddDirections();
        _currentRotation = new Vector3();
        _gravity.SwitchGravity();
    }
    public void AddDirections()
    {
        directions.Add(Vector2.left, new Vector3(0, 90, 0));
        directions.Add(Vector2.right, new Vector3(0, -90, 0));
        directions.Add(Vector2.up, new Vector3(90, 0, 0));
        directions.Add(Vector2.down, new Vector3(-90, 0, 0));
        directions.Add(new Vector3(0,0,1), new Vector3(0, 0, 90));
        directions.Add(new Vector3(0, 0,-1), new Vector3(0, 0, -90));
    } 
    IEnumerator RotateLevel(Vector3 dir)
    {
        isTurning = true;
        _gravity.SwitchGravity();
        var targetAngle = _currentRotation + directions[dir];//Kijkt naar de angle waar die naartoe moet.
        float time = 0;
        float duration = 0.5f;
        while (time < duration)//Wanneer de angle dat die is niet gelijk is aan de angle waar die naartoe moet.
        {
            time += Time.deltaTime;
            var newPosition = Vector3.Lerp(_currentRotation, targetAngle, time / duration);
            newPosition.x %= 360;
            newPosition.y %= 360;
            newPosition.z %= 360;
            world.transform.eulerAngles = newPosition;
            yield return null;
        }
        _currentRotation += directions[dir];
        isTurning = false;
        _gravity.SwitchGravity();
    }
    public void InputDirection(InputAction.CallbackContext context)//Kijkt naar welke knop je indrukt.
    {
        if (this == null) return;
        if (!isTurning)
        {
            var dir = inputControls.Rotate.ReadValue<Vector2>(); //kijkt naar welke knoppen je indrukt.
            if (dir == null) return;

            if(_routine != null)
            {
                StopCoroutine(_routine);
            }
            _routine = RotateLevel(dir);
            StartCoroutine(_routine);
        }
        else
        {
            Debug.Log("i'm busy ");
        }
    }

    public void RotateLevelZUp(InputAction.CallbackContext context)
    {
        if (this == null) return;
        if (!isTurning)
        {
            var dir = new Vector3(0, 0, 1);
            if (_routine != null)
            {
                StopCoroutine(_routine);
            }
            _routine = RotateLevel(dir);
            StartCoroutine(_routine);
        }
        else
        {
            Debug.Log("i'm busy ");
        }
    }

    public void RotateLevelZDown(InputAction.CallbackContext context)
    {
        if (this == null) return;
        if (!isTurning)
        {
            var dir = new Vector3(0, 0, -1);
            if (dir == null) return;
            if (_routine != null)
            {
                StopCoroutine(_routine);
            }
            _routine = RotateLevel(dir);
            StartCoroutine(_routine);
        }
        else
        {
            Debug.Log("i'm busy ");
        }
    }
}

