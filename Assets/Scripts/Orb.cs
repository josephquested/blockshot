using UnityEngine;
using System.Collections;

public class Orb : MonoBehaviour
{
	void OnTriggerEnter (Collider collider)
	{
		if (collider.CompareTag("Player"))
		{
			GameObject.FindWithTag("Exit").GetComponent<Exit>().OrbCollected();
			Destroy(gameObject);
		}
	}
}
