using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour 
{
	[SerializeField] protected GameObject goal;

	public static bool goalSpawned;

	void Start() 
	{
		
	}
	
	void Update () 
	{
		if (goalSpawned == false)
		{
			Vector3 spawnLocation = new Vector3(Random.Range(13f, -13f), 0.501f, Random.Range(13f, -13f));

			Instantiate(goal, spawnLocation, transform.rotation);

			goalSpawned = true;
		}
	}
}
