using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(EndlessRunnerCharacter2D))]
public class EndlessRunner2DUserControl : MonoBehaviour 
{
	EndlessRunnerCharacter2D m_Character;
	bool m_Jump;
	bool m_EnableCrouch = false;
	float m_HorizontalInput = 1f;

	void Awake()
	{
		m_Character = GetComponent<EndlessRunnerCharacter2D>();
	}


	void Update()
	{
		if (!m_Jump)
		{
			// Read the jump input in Update so button presses aren't missed.
			m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
		}
	}


	void FixedUpdate()
	{
		// Pass all parameters to the character control script.
		m_Character.Move(m_HorizontalInput, m_EnableCrouch, m_Jump);
		m_Jump = false;
	}

}
