using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputParse : MonoBehaviour
{
    private FPControl _control;
    private FPControl.PlayerControlsActions _inputControls;
    private MovementPlayer _movementPlayer;
    private LevelRotate _levelRotate;
    private DeWKnop _deWknop;
    public bool _isRotating;
    public bool _canGrab;

    private void Start()
    {
        _movementPlayer = GetComponent<MovementPlayer>();
        _levelRotate = FindObjectOfType<LevelRotate>();
        _deWknop = FindObjectOfType<DeWKnop>();
        _control = new FPControl(); // Maakt nieuwe controls aan.
        _inputControls = _control.PlayerControls; // Maakt een instantie van de knoppen die zijn aangemaakt?
        _levelRotate._inputControls = _inputControls;
        _inputControls.Jump.performed += _movementPlayer.Jump; // Elke keer als die preformed word dan roept hij de jump aan.
        _inputControls.Gravity.performed += _deWknop.PressE;
        _inputControls.StartRotating.performed += _ => _isRotating = true;
        _inputControls.StartRotating.canceled += _ => _isRotating = false; // Wanneer je het niet ingedrukt houd dan mag niet rotaten.
        _inputControls.StartRotating.performed += _levelRotate.SavePosition;
        _inputControls.Enable();//Functie die zegt dat die de inputcontrols mag gebruiken.
    }
    private void Update()
    {
        _movementPlayer.Walking(_inputControls.Walking.ReadValue<Vector2>());//Kijkt in inputcontrols of die walking heeft daarna zoekt die naar de value van vector 2.
        if (_isRotating)
        {
            _levelRotate.Rotate(_inputControls.MousePosition.ReadValue<Vector2>(), _inputControls.MouseDelta.ReadValue<Vector2>());
        }
        
    }
}
