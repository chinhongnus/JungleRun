using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEvents : MonoBehaviour {

	public CanvasGroup startGroup;
	public CanvasGroup endGroup;

	AudioSource audioSource;
	public AudioClip music;
	public GameObject player;

	const float fadeTime = 0.5f;
	const float fadePerSecond = 1.0f / fadeTime;
	float fadeFactor = 0.0f;

	bool hasTriggeredStart = false;

	// Use this for initialization
	void Start()
	{
		audioSource = gameObject.GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{
		if (!hasTriggeredStart)
		{
			return;
		}

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
			player.SetActive(true);
		}

		startGroup.alpha = 1.0f - fadeFactor;
		endGroup.alpha = fadeFactor;
	}

	public void OnTriggerStart()
	{
		hasTriggeredStart = true;
		if (audioSource != null && music != null)
		{
			audioSource.PlayOneShot(music);
		}
	}
}
