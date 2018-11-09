using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour 
{
	protected int score;

	void Start() 
	{
		score = 0;
	}

	void OnTriggerEnter(Collider collider)
	{
		score += 1;
		Destroy(gameObject);
		Spawner.goalSpawned = false;
	}
}
