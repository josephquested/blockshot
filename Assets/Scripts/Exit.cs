using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {
	GameController gameController;

	void Awake ()
	{
		gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
	}

	void OnTriggerEnter (Collider collider)
	{
		if (collider.CompareTag("Player"))
		{
			gameController.Win();
		}
	}
}
