using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class WindForce : MonoBehaviour 
{
	protected int powerLevel;
	protected float windPower;
	protected float windPower0;
	[SerializeField] protected float windPower1;
	[SerializeField] protected float windPower2;
	[SerializeField] protected float windPower3;

	void Start() 
	{
		windPower0 = 0;
		powerLevel = 0;
	}
	
	void Update()
	{
		RaycastHit hit;

		if (Physics.Raycast(transform.position, transform.forward, out hit, 30))
		{
			if (hit.rigidbody != null)
				hit.rigidbody.AddForce(hit.normal * windPower * -1);

			Debug.DrawRay(transform.position, transform.forward * 30, Color.red);
		}

		if (Physics.Raycast(transform.position + new Vector3(0.8f ,0 ,0), transform.forward, out hit, 30))
		{
			if (hit.rigidbody != null)
				hit.rigidbody.AddForce(hit.normal * windPower * -1);

			Debug.DrawRay(transform.position + new Vector3(0.8f ,0 ,0), transform.forward * 30, Color.red);
		}

		if (Physics.Raycast(transform.position - new Vector3(0.8f ,0 ,0), transform.forward, out hit, 30))
		{
			if (hit.rigidbody != null)
				hit.rigidbody.AddForce(hit.normal * windPower * -1);

			Debug.DrawRay(transform.position - new Vector3(0.8f ,0 ,0), transform.forward * 30, Color.red);
		}
	}

	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(0))
		{
			if (powerLevel == 0)
			{
				windPower = windPower1;
				powerLevel = 1;
				Debug.Log(powerLevel);
			}
			else if (powerLevel == 1)
			{
				windPower = windPower2;
				powerLevel = 2;
				Debug.Log(powerLevel);
			}
			else if (powerLevel == 2)
			{
				windPower = windPower3;
				powerLevel = 3;
				Debug.Log(powerLevel);
			}
			else if (powerLevel == 3)
			{
				windPower = windPower0;
				powerLevel = 0;
				Debug.Log(powerLevel);
			}
		}
	}
}
