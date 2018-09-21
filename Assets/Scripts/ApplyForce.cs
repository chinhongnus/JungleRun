using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour 
{
	public float thrustX;
	public float thrustY;
	Rigidbody2D rb;

	bool activated = false;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		/*
		if (activated)
		{
			Vector2 thrust = new Vector2(thrustX, thrustY);
			rb.AddForce(thrust, ForceMode2D.Impulse);
		}
		*/
	}

	public void ApplyThrust(float X, float Y)
	{
		activated = true;
		thrustX = X;
		thrustY = Y;
		Vector2 thrust = new Vector2(thrustX, thrustY);
		rb.AddForce(thrust, ForceMode2D.Impulse);
	}
}
