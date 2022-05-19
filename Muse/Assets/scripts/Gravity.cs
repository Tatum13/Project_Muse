using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
	private DeWKnop boel;
	public Vector3 speed;
	public float gravity = 9.8f;

	// Start() is called before the first frame
	void Start()
	{
		speed = new Vector3(0f, 0f, 0f);
		boel = GameObject.Find("Directional Light").GetComponent<DeWKnop>();

	}
    private void Update()
    {
	}
    // FixedUpdate() is called at regular time intervals independent of frames
    void FixedUpdate()
	{

		if(boel.grav == true) {
			Debug.Log("de neuk");
			speed.Set(speed.x, speed.y - gravity * Time.fixedDeltaTime, speed.z);
			transform.position += speed;
		}

	}
}
