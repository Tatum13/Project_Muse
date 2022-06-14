using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gravity : MonoBehaviour
{
	private DeWKnop boel;
	[SerializeField] private Rigidbody rb;
	[SerializeField] private bool testClick;

	// Start() is called before the first frame
	void Start()
	{
		boel = GameObject.Find("Directional Light").GetComponent<DeWKnop>();
		rb = GetComponent<Rigidbody>();
	}
	public void TestGravity(InputAction.CallbackContext context)
    {
		rb.useGravity = true;
	}
     
}
