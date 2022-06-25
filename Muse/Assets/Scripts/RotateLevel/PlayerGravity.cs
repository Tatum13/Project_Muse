using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerGravity : MonoBehaviour
{
	private LevelRotater _turnFinal;
	private Rigidbody _rb;

	void Awake()
	{
		_turnFinal = GameObject.Find("RotateSpot").GetComponent<LevelRotater>();
		_rb = GetComponent<Rigidbody>();
		_rb.useGravity = true;
	}
	public void SwitchGravity()
    {
		if (_turnFinal.isTurning == true)
		{
			_rb.useGravity = false;
			_rb.velocity = Vector3.zero;
		}
		else 
		{ 
			_rb.useGravity = true;
		}
	}
     
}
