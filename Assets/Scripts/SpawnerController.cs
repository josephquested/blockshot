using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour {
	public GameObject spawnerPrefab;
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
			Spawn();
			StartCoroutine(CooldownRoutine());
		}
	}

	void Spawn ()
	{
		var spawnedObj = Instantiate(spawnerPrefab, transform.position, transform.rotation);
	}

	IEnumerator CooldownRoutine ()
	{
		canSpawn = false;
		yield return new WaitForSeconds(cooldown);
		canSpawn = true;
	}
}
