using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossFade : MonoBehaviour {

	public CanvasGroup startGroup;
	public CanvasGroup endGroup;

	const float fadeTime = 2.5f;
	const float fadePerSecond = 1.0f / fadeTime;
	float fadeFactor = 0.0f;

	// Use this for initialization
	void Start () 
	{
		
	}
	

	void Update()
	{
		if (startGroup == null || endGroup == null) 
		{
			return;
		}

		if (fadeFactor >= 1.0f)
		{
			return;
		}

		fadeFactor += fadePerSecond * Time.deltaTime;

		if (fadeFactor > 1.0f)
		{
			fadeFactor = 1.0f;
		}

		startGroup.alpha = 1.0f - fadeFactor;
		endGroup.alpha = fadeFactor;
	}
}
