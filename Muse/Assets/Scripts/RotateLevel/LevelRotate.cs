using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelRotate : MonoBehaviour
{
    private Gravity Grav;
    public FPControl.PlayerControlsActions _inputControls;
    public InputParse _input;
    [SerializeField] private GameObject world;
    public bool _isTurning = false;

    public Dictionary<Vector2, Vector3> directions = new Dictionary<Vector2, Vector3>();

    private Vector3 _currentRotation;
    //private Vector3 _rotationZ;
    private IEnumerator routine;

    private void Start()
    {
        world = GameObject.Find("3");
        Grav = GameObject.Find("Player").GetComponent<Gravity>();
        AllDirections();
        _currentRotation = new Vector3();
        Grav.Grav();
        //_rotationZ = new Vector3();
    }
    public void AllDirections()
    {
        directions.Add(Vector2.left, new Vector3(0, 90, 0));
        directions.Add(Vector2.right, new Vector3(0, -90, 0));
        directions.Add(Vector2.up, new Vector3(90, 0, 0));
        directions.Add(Vector2.down, new Vector3(-90, 0, 0));
    } 
    IEnumerator KeysPressed(Vector2 dir)
    {
        _isTurning = true;
        Grav.Grav();
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
        _isTurning = false;
        Grav.Grav();
    }
    public void Pressed(InputAction.CallbackContext context)//Kijkt naar welke knop je indrukt.
    {
        if (!_isTurning)
        {
            var dir = _inputControls.Rotate.ReadValue<Vector2>(); //kijkt naar welke knoppen je indrukt.
            //var dirZ = _inputControls.RotateZ.ReadValue<Vector3>();
            if(routine != null)
            {
                StopCoroutine(routine);
            }
            routine = KeysPressed(dir);
            StartCoroutine(routine);
        }
        else
        {
            Debug.Log("i'm busy ");
        }
    }
}

