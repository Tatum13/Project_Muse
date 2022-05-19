using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
	private DeWKnop boel;
	public Vector3 speed;
	public float gravity;
	[SerializeField] private Rigidbody rb;

	// Start() is called before the first frame
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		speed = new Vector3(0f, 0f, 0f);
		boel = GameObject.Find("Level").GetComponent<DeWKnop>();

	}
    private void Update()
    {
	}
    // FixedUpdate() is called at regular time intervals independent of frames
    void FixedUpdate()
	{

		if(boel.grav == true)
        {
			rb.useGravity = true;
		}

	}
}
