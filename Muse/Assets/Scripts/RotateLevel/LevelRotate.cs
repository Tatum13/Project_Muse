using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelRotate : MonoBehaviour
{
    //[SerializeField] private float _rotateSpeed;
    //[SerializeField] private Vector3 _rotation;
    public FPControl.PlayerControlsActions _inputControls;
    [SerializeField] private GameObject world;
   // [SerializeField] private Vector3 _oldPosition;
    //[SerializeField] private Vector3 _currentPosition;

    //[SerializeField] private float _rotateLvlSpeed;
    [SerializeField] private bool _isTurning;
    //[SerializeField] private bool _isFullyTurning;
    [SerializeField] private float rotate;
    //[SerializeField] private float x;
    //[SerializeField] private float y;

    private Timer timer;
    private float _rotated = 0;
    private float turned;

    private void Start()
    {
        //world =  FindObjectOfType<GameObject>();
        world = GameObject.Find("Level");
        timer = new Timer(2);
        _isTurning = true;
    }
    private void Update()
    {
        
        if (_isTurning == true)
        {
            if (!timer.Update(Time.deltaTime))
            {
                rotate = (timer.Percentage * 90) - _rotated;
                _rotated += rotate;
                world.transform.Rotate(0, rotate , 0);
            }
            else
            {
                _isTurning = false;
                timer.Reset();
                world.transform.Rotate(0, 90 - _rotated, 0);
                _rotated = 0;   
                //GravitySensor aan
            }

            //
            //StartCoroutine(TurnTime());
            //_rotateLvlSpeed = 45;
        }
    }
    /*
    IEnumerator TurnTime()
    {
        rotate = _rotateLvlSpeed * Time.deltaTime;
        yield return new WaitForSeconds(2);
        _isTurning = false;
        _rotateLvlSpeed = 0;
        //rotate = Mathf.Floor(rotate);
        world.transform.Rotate(0, y, 0);
        Debug.Log(_rotateLvlSpeed);
    }
    public void RotateLvl(Vector3 turnDir)
    {
        var rotateDir = new Vector3(turnDir.x, turnDir.y, turnDir.z);
        transform.position += rotateDir * _rotateLvlSpeed * Time.deltaTime;
    }
    */
    /*
    public void Rotate(Vector2 mousePos, Vector2 delta)//Delta kijkt waar de mouse heen gaat.
    {
        _currentPosition = mousePos;
        var mouseYDistance = _currentPosition.y - _oldPosition.y;// Krijg je de afstand tussen de 2 punten
        var mouseXDistance = _currentPosition.x - _oldPosition.x;
        if (_currentPosition.y > _oldPosition.y && Mathf.Abs(mouseYDistance) > 2)//Werkt altijd met positieve nummers (werkt altijd).
        {
            transform.Rotate(delta.y / _rotateSpeed, 0, 0);
        }
        else if(_currentPosition.x > _oldPosition.x && Mathf.Abs(mouseXDistance) > 2)
        {
            transform.Rotate(0, -delta.x / _rotateSpeed, 0);
        }

        //transform.Rotate(_rotation * _rotateSpeed * Time.deltaTime);
    }

    public void SavePosition(InputAction.CallbackContext context)
    {
        _oldPosition = _currentPosition;
    }
    */
}
