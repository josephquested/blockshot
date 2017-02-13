using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
	public int damage;

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "Bound")
		{
			Destroy(gameObject);
		}
		if (collider.GetComponent<Status>() != null)
		{
			collider.GetComponent<Status>().TakeDamage(damage);
			Destroy(gameObject);
		}
	}
}
