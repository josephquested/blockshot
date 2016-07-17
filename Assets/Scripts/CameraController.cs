using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	Transform target;
	public bool trackPlayer;

	void Start ()
	{
		target = GameObject.FindWithTag("Player").transform;
	}

	void FixedUpdate ()
	{
		if (trackPlayer)
		{
			transform.position = new Vector3(
			target.position.x,
			10,
			target.position.z
			);
		}
	}
}
