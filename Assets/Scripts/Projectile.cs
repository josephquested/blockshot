using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "Bound")
		{
			Destroy(gameObject);
		}
	}
}
