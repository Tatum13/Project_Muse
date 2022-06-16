using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gravity : MonoBehaviour
{
	[SerializeField] private Rigidbody rb;
	private LevelRotate turn;

	void Start()
	{
		turn = GameObject.Find("Level").GetComponent<LevelRotate>();
		rb = GetComponent<Rigidbody>();
		rb.useGravity = true;
	}
	public void Grav()
	{
		if (turn._isTurning == true)
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
