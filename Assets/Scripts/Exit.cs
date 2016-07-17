using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Exit : MonoBehaviour {
	GameController gameController;
	List<GameObject> orbs = new List<GameObject>();
	public GameObject exitLock;

	void Awake ()
	{
		gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
	}

	void Start ()
	{
		FindOrbs();
	}

	void OnTriggerEnter (Collider collider)
	{
		if (collider.CompareTag("Player") && exitLock == null)
		{
			gameController.Win();
		}
	}

	void FindOrbs ()
	{
		GameObject[] orbsArr = GameObject.FindGameObjectsWithTag("Orb");
		for (int i = 0; i < orbsArr.Length; i++)
		{
			orbs.Add(icon);
		}
	}

	public void OrbCollected ()
	{
		orbs.RemoveAt(0);
		UpdateLock();
	}

	void UpdateLock ()
	{
		if (orbs.Count == 0)
		{
			Destroy(exitLock);
		}
	}
}
