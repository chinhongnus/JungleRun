using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D otherGameObject)
	{
		if (otherGameObject.tag == "Player")
		{
			Debug.Break();
			return;
		}

		if (otherGameObject.gameObject.transform.parent)
		{
			Destroy(otherGameObject.gameObject.transform.parent.gameObject);
		}
		else
		{
			Destroy(otherGameObject);
		}
	}
}
