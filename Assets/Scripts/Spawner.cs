using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	[SerializeField] GameObject[] m_SpawnItems;
	[SerializeField] float m_TimeBeforeSpawnMin;
	[SerializeField] float m_TimeBeforeSpawnMax;
	[SerializeField] float m_SpawnTimeMin;
	[SerializeField] float m_SpawnTimeMax;

	Transform _startPosition;
	float _nextSpawnTime = 0.0f;

	// Use this for initialization
	void Start () 
	{
		_startPosition = transform;
		_nextSpawnTime = Random.Range(m_TimeBeforeSpawnMin, m_TimeBeforeSpawnMax);
		if (m_SpawnItems.Length > 0)
		{
			StartCoroutine(SpawnGround());
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	IEnumerator SpawnGround()
	{
		yield return new WaitForSeconds(_nextSpawnTime);

		GameObject groundTile = Instantiate(m_SpawnItems[Random.Range(0, m_SpawnItems.Length)], _startPosition);

		_nextSpawnTime = Random.Range(m_SpawnTimeMin, m_SpawnTimeMax);
		StartCoroutine(SpawnGround());
	}
}
