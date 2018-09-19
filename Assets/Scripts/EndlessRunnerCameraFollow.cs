using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRunnerCameraFollow : MonoBehaviour 
{
	public Transform target;
	float m_ChaseOffset = 6.0f;

	// Update is called once per frame
	private void Update()
	{
		transform.position = new Vector3(target.position.x + m_ChaseOffset, 0f, transform.position.z);
	}
}
