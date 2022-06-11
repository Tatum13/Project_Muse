using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputParse : MonoBehaviour
{
    public FPControl _control;
    public FPControl.PlayerControlsActions _inputControls;
    private MovementPlayer _movementPlayer;
    private LevelRotate _levelRotate;

    private PauseMenu _pauseMenu;

    private Gravity _gravity;

    public bool _isRotating;

    private void Start()
    {
        _movementPlayer = GetComponent<MovementPlayer>();
        _levelRotate = FindObjectOfType<LevelRotate>();
        _pauseMenu = FindObjectOfType<PauseMenu>();
        _control = new FPControl(); // Maakt nieuwe controls aan.
        _inputControls = _control.PlayerControls; // Maakt een instantie van de knoppen die zijn aangemaakt?
        _levelRotate._inputControls = _inputControls;
        _inputControls.Jump.performed += _movementPlayer.Jump; // Elke keer als die preformed word dan roept hij de jump aan.
        _inputControls.StartRotating.performed += _ => _isRotating = true;
        _inputControls.StartRotating.canceled += _ => _isRotating = false; // Wanneer je het niet ingedrukt houd dan mag niet rotaten.
        _inputControls.StartRotating.performed += _levelRotate.SavePosition;
        _inputControls.PauseGame.performed += _pauseMenu.PauseGame; //Wanneer je esc drukt moet de game op pauze.

        _gravity = FindObjectOfType<Gravity>();
        _inputControls.Gravity.performed += _gravity.TestGravity;
        _inputControls.Rotate.performed += _levelRotate.Pressed;
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
