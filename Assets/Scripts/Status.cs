using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour {
	public int health;

	Color originalColor;

	void Awake ()
	{
		originalColor = GetComponent<Renderer>().material.color;
	}

	void Update ()
	{
		if (health <= 0)
		{
			Destroy(gameObject);
		}
	}

	public void TakeDamage (int damage)
	{
		health -= damage;
		StartCoroutine(FlashRoutine());
	}

	IEnumerator FlashRoutine () {
		Renderer rend = GetComponent<Renderer>();
  	rend.material.color = Color.red;
		yield return new WaitForSeconds(0.04f);
		rend.material.color = Color.black;
		yield return new WaitForSeconds(0.025f);
		rend.material.color = Color.red;
		yield return new WaitForSeconds(0.04f);
		rend.material.color = originalColor;
	}
}
