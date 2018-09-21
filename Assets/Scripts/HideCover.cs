using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCover : MonoBehaviour {

	public GameObject coverPanel;

	// Use this for initialization
	void Start () 
	{
		if (coverPanel != null)
		{
			coverPanel.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
