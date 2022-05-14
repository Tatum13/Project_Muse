using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelRotate : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
    //[SerializeField] private Vector3 _rotation;
    public FPControl.PlayerControlsActions _inputControls;
    [SerializeField] private GameObject world;
    [SerializeField] private Vector3 _oldPosition;
    [SerializeField] private Vector3 _currentPosition;

    private void Start()
    {
        world =  FindObjectOfType<GameObject>();
    }
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
}
