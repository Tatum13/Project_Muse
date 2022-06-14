using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gravity : MonoBehaviour
{
	private LevelRotate Turn;
	[SerializeField] private Rigidbody rb;

	// Start() is called before the first frame
	void Start()
	{
		Turn = GameObject.Find("Level").GetComponent<LevelRotate>();
		rb = GetComponent<Rigidbody>();
		rb.useGravity = true;
	}
	public void Grav()
    {
		if (Turn._isTurning == true)
		{
			rb.useGravity = false;
			rb.velocity = Vector3.zero;
		}
		else 
		{ 
		rb.useGravity = true;
		}
	}
     
}

