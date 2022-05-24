using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputParse : MonoBehaviour
{
    private FPControl _control;
    private FPControl.PlayerControlsActions _inputControls;
    private MovementPlayer _movementPlayer;

    private void Start()
    {
        _movementPlayer = GetComponent<MovementPlayer>();
        _control = new FPControl(); // Maakt nieuwe controls aan.
        _inputControls = _control.PlayerControls; // Maakt een instantie van de knoppen die zijn aangemaakt?
        //_inputControls.Jump.performed += _movementPlayer.Jump; // Elke keer als die preformed word dan roept hij de jump aan.
        _inputControls.Enable();//Functie die zegt dat die de inputcontrols mag gebruiken.
    }
    private void Update()
    {
        _movementPlayer.Walking(_inputControls.Walking.ReadValue<Vector2>());//Kijkt in inputcontrols of die walking heeft daarna zoekt die naar de value van vector 2.
    }
}
