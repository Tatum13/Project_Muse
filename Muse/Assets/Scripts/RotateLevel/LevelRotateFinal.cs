using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelRotateFinal : MonoBehaviour
{
    public FPControl.PlayerControlsActions _inputControls;
    public InputParse _input;
    public bool _isTurning = false;
    public Dictionary<Vector3, Vector3> directions = new Dictionary<Vector3, Vector3>();
    [SerializeField] private GameObject _world;
    private Gravity _grav;
    private MovementPlayer _movement;
    private Vector3 _currentRotation;
    private IEnumerator _routine;
    private Vector2 _dir;

    private void Start()
    {
        _world = GameObject.Find("RotateSpot");
        _grav = GameObject.Find("Player").GetComponent<Gravity>();
        AllDirections();
        _currentRotation = new Vector3();
        _dir = GetComponent<Vector2>();
        _grav.Grav();
        //_rotationZ = new Vector3();
    }
    public void AllDirections()
    {
        directions.Add(Vector2.left, new Vector3(0, 90, 0));
        directions.Add(Vector2.right, new Vector3(0, -90, 0));
        directions.Add(Vector2.up, new Vector3(90, 0, 0));
        directions.Add(Vector2.down, new Vector3(-90, 0, 0));
        directions.Add(new Vector3(0, 0, 1), new Vector3(0, 0, 90));
        directions.Add(new Vector3(0, 0, -1), new Vector3(0, 0, -90));
    }
    public void KeysPressed(Vector3 dir)
    {
        _isTurning = true;
        _grav.Grav();
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
            _world.transform.eulerAngles = newPosition;
            //yield return null;
        }
        _currentRotation += directions[dir];
        _isTurning = false;
        _grav.Grav();
    }
    public void Pressed(InputAction.CallbackContext context)//Kijkt naar welke knop je indrukt.
    {
        if (!_isTurning)
        {
            _dir = _inputControls.Rotate.ReadValue<Vector2>(); //kijkt naar welke knoppen je indrukt.
            //var dirZ = _inputControls.RotateZ.ReadValue<Vector3>();
            if (_routine != null)
            {
                StopCoroutine(_routine);
            }
            KeysPressed(_dir);
            StartCoroutine(_routine);
        }
        else
        {
            Debug.Log("i'm busy ");
        }
    }

    public void PressedZUP(InputAction.CallbackContext context)
    {
        if (!_isTurning)
        {
            var dir = new Vector3(0, 0, 1);
            if (_routine != null)
            {
                StopCoroutine(_routine);
            }
            KeysPressed(dir);
            StartCoroutine(_routine);
        }
        else
        {
            Debug.Log("i'm busy ");
        }
    }

    public void PressedZDOWN(InputAction.CallbackContext context)
    {
        if (!_isTurning)
        {
            var dir = new Vector3(0, 0, -1);
            if (_routine != null)
            {
                StopCoroutine(_routine);
            }
            KeysPressed(dir);
            StartCoroutine(_routine);
        }
        else
        {
            Debug.Log("i'm busy ");
        }
    }
}
