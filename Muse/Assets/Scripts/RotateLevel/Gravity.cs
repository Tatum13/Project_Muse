using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gravity : MonoBehaviour
{
	//private LevelRotate _turn;
	private LevelRotate _turnFinal;
	[SerializeField] private Rigidbody rb;

	// Start() is called before the first frame
	void Awake()
	{
		_turnFinal = GameObject.Find("RotateSpot").GetComponent<LevelRotate>();
		rb = GetComponent<Rigidbody>();
		rb.useGravity = true;
	}
	public void Grav()
    {
		if (_turnFinal._isTurning == true)
		{
			rb.useGravity = false;
			rb.velocity = Vector3.zero;
			//gameObject.transform.localRotation = gameObject.transform.parent.rotation;
		}
		else 
		{ 
			rb.useGravity = true;
		}
	}
     
}
