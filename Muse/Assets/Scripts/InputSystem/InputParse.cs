using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputParse : MonoBehaviour
{
    public FPControl _control;
    public FPControl.PlayerControlsActions _inputControls;
    private MovementPlayer _movementPlayer;
    private LevelRotate _levelRotate;
    private Gravity _gravity;
    public bool _isRotating;
    public bool _canGrab;

    private void Start()
    {
        _movementPlayer = GetComponent<MovementPlayer>();
        _levelRotate = FindObjectOfType<LevelRotate>();
        _gravity = FindObjectOfType<Gravity>();
        _control = new FPControl(); // Maakt nieuwe controls aan.
        _inputControls = _control.PlayerControls; // Maakt een instantie van de knoppen die zijn aangemaakt?
        _levelRotate._inputControls = _inputControls;


        _inputControls.Rotate.performed += _levelRotate.Pressed;

        _inputControls.StartRotating.performed += _ => _isRotating = true;
        _inputControls.StartRotating.canceled += _ => _isRotating = false; // Wanneer je het niet ingedrukt houd dan mag niet rotaten.
        _inputControls.Enable();//Functie die zegt dat die de inputcontrols mag gebruiken.
    }
    private void Update()
    {
        _movementPlayer.Walking(_inputControls.Walking.ReadValue<Vector2>());//Kijkt in inputcontrols of die walking heeft daarna zoekt die naar de value van vector 2.
        //_levelRotate.RotateLvl(_inputControls.LevelRotate.ReadValue<Vector3>());
        /*
        if (_isRotating)
        {
            _levelRotate.Rotate(_inputControls.MousePosition.ReadValue<Vector2>(), _inputControls.MouseDelta.ReadValue<Vector2>());
        }
        */
        
    }
}
