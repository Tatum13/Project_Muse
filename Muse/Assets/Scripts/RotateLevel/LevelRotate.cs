using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelRotate : MonoBehaviour
{
    //[SerializeField] private float _rotateSpeed;
    //[SerializeField] private Vector3 _rotation;
    public FPControl.PlayerControlsActions _inputControls;
    public InputParse _input;
    [SerializeField] private GameObject world;
    [SerializeField] private bool _isTurning = false;
    [SerializeField] private float rotateDir;

    public Dictionary<Vector2, Vector3> directions = new Dictionary<Vector2, Vector3>();

    private Timer timer;
    private float _rotated = 0;
    private float turned;

    private void Start()
    {
        //world =  FindObjectOfType<GameObject>();
        world = GameObject.Find("Level");
        timer = new Timer(2);
        AllDirections();
    }
    public void AllDirections()
    {
        directions.Add(Vector2.left, new Vector3(0, 90, 0));
        directions.Add(Vector2.right, new Vector3(0, -90, 0));
        directions.Add(Vector2.up, new Vector3(90, 0, 0));
        directions.Add(Vector2.down, new Vector3(-90, 0, 0));
    }
    IEnumerator Keys(Vector2 dir)
    {
        if (!_isTurning)//Als _isTurning false is zet het naar true.
        {
            _isTurning = true;
            var angle = transform.eulerAngles;//Kijkt naar wat de angle nu is.
            var targetAngle = angle + directions[dir];//Kijkt naar de angle waar die naartoe moet.
            var time = 0f;
            while (angle != targetAngle)
            {
                time = time > 1 ? 1 : time + 0.001f; ;//Als time hoger is dan 1, zo niet doe time + 0.001f.
                var newPosition = Vector3.Lerp(angle, targetAngle, time);
                world.transform.Rotate(newPosition);
                angle = transform.eulerAngles;
                yield return null;
            }
            yield return null; 
        }
    }
    public void Pressed(InputAction.CallbackContext context)//Kijkt naar welke knop je indrukt.
    {
        var dir = _inputControls.Rotate.ReadValue<Vector2>();
        StartCoroutine(Keys(dir));
        Debug.Log(dir);
    }
    public void RotateLeft(InputAction.CallbackContext context)
    {        
        if (_isTurning == true)
        {
            if (!timer.Update(Time.deltaTime))
            {       
                rotateDir = (timer.Percentage * 90) - _rotated;
                _rotated += rotateDir;
                world.transform.Rotate(0, rotateDir, 0);
                Debug.Log("rotate werkt"); 
            }
            else
            {
                _isTurning = false;
                timer.Reset();
                world.transform.Rotate(0, 90 - _rotated, 0);
                _rotated = 0;
                Debug.Log("Hij gaat op false");
                //GravitySensor aan
            }
        }     
    }
}
