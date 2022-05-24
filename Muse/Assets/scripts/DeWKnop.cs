using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DeWKnop : MonoBehaviour
{
    public bool grav = false;

    public void PressE(InputAction.CallbackContext context)
    {
        grav = true;
    }
}
