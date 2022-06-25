using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputParse : MonoBehaviour
{
    public FPControl control;
    public FPControl.PlayerControlsActions inputControls;
    public bool _isRotating;
    [SerializeField] private LevelRotater levelRotate;
    private PlayerMovement _movementPlayer;
    private PauseMenu _pauseMenu;
    private PlayerGravity _gravity;

    private void Start()
    {
        _movementPlayer = GetComponent<PlayerMovement>();
        levelRotate = FindObjectOfType<LevelRotater>();
        _pauseMenu = FindObjectOfType<PauseMenu>();
        control = new FPControl(); // Maakt nieuwe controls aan.
        inputControls = control.PlayerControls; // Maakt een instantie van de knoppen die zijn aangemaakt?
        levelRotate.inputControls = inputControls;
        inputControls.PauseGame.performed += _pauseMenu.PauseGame; //Wanneer je esc drukt moet de game op pauze.
        inputControls.RotateZUP.performed += levelRotate.RotateLevelZUp;
        inputControls.RotateZDOWN.performed += levelRotate.RotateLevelZDown;

        _gravity = FindObjectOfType<PlayerGravity>();
        inputControls.Rotate.performed += levelRotate.InputDirection;
        inputControls.Enable();//Functie die zegt dat die de inputcontrols mag gebruiken.
    }
    private void Update()
    {
        _movementPlayer.Walking(inputControls.Walking.ReadValue<Vector2>());//Kijkt in inputcontrols of die walking heeft daarna zoekt die naar de value van vector 2.
    }
}
