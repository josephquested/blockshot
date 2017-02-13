using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public Transform spawnZone;
	public GameObject spawnPrefab;
	public float cooldown;

	bool canSpawn;

	void Start ()
	{
		StartCoroutine(CooldownRoutine());
	}

	void Update ()
	{
		if (canSpawn)
		{
			if (spawnZone != null)
			{
				Spawn(RandomPositionInZone());
			}
			else
			{
				Spawn(transform.position);
			}
		}
	}

	void Spawn (Vector3 spawnPosition)
	{
		print(spawnPosition);
		var spawnedObj = Instantiate(spawnPrefab, spawnPosition, transform.rotation);
		StartCoroutine(CooldownRoutine());
	}

	Vector3 RandomPositionInZone ()
	{
		return new Vector3(
			Random.Range(-spawnZone.localScale.x / 2, spawnZone.localScale.x / 2),
			0.5f,
			Random.Range(-spawnZone.localScale.z / 2, spawnZone.localScale.z / 2)
		);
	}

	IEnumerator CooldownRoutine ()
	{
		canSpawn = false;
		yield return new WaitForSeconds(cooldown);
		canSpawn = true;
	}
}
