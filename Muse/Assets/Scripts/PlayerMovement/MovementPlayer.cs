using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Walking(Vector3 position)
    {
        var moveDirection = new Vector3(position.x, 0, position.y); //de z word een y wegens dat je niet springt.
        transform.position += moveDirection * speed * Time.deltaTime;
    }
    public void Jump(InputAction.CallbackContext context)//Vraagt naar welke button die heeft.
    {
        if (Mathf.Abs(rb.velocity.y) < 0.001f)// groundcheck
        {
            rb.AddForce(new Vector3(0, jumpForce), ForceMode.Impulse);
        }
    }
}
