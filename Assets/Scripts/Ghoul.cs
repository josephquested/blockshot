using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Ghoul : MonoBehaviour {
 	Transform goal;
	NavMeshAgent agent;

	void Start () {
		agent = GetComponent<NavMeshAgent>();
		if (GameObject.FindWithTag("Player") != null)
		{
			goal = GameObject.FindWithTag("Player").transform;
		}
	}

	void Update ()
	{
		if (goal != null)
		{
			agent.destination = goal.position;
		}
	}
}
