using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour 
{
	public static int score = 0;

	void OnTriggerEnter(Collider collider)
	{
		if (Menu.hasPlayed == true)
			score += 1;

		Destroy(gameObject);
		Spawner.goalSpawned = false;
	}
}
