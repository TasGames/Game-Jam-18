using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class WindForce : MonoBehaviour 
{
	[SerializeField] WindBlockMovement wBM;
	protected int powerLevel;
	protected float windPower;
	protected float windPower0;
	[SerializeField] protected float windPower1;
	[SerializeField] protected float windPower2;
	[SerializeField] protected float windPower3;
	[SerializeField] protected GameObject pT1;
	[SerializeField] protected GameObject pT2;
	[SerializeField] protected GameObject pT3;
	[SerializeField] protected GameObject pT1A;
	[SerializeField] protected GameObject pT2A;
	[SerializeField] protected GameObject pT3A;
	[SerializeField] protected ParticleSystem wind;

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

		if (wBM.isHorizontal == true)
		{
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
		else
		{
			if (Physics.Raycast(transform.position + new Vector3(0, 0 ,0.8f), transform.forward, out hit, 30))
			{
				if (hit.rigidbody != null)
					hit.rigidbody.AddForce(hit.normal * windPower * -1);

				Debug.DrawRay(transform.position + new Vector3 (0, 0 ,0.8f), transform.forward * 30, Color.red);
			}

			if (Physics.Raycast(transform.position - new Vector3(0, 0 ,0.8f), transform.forward, out hit, 30))
			{
				if (hit.rigidbody != null)
					hit.rigidbody.AddForce(hit.normal * windPower * -1);

				Debug.DrawRay(transform.position - new Vector3(0, 0 ,0.8f), transform.forward * 30, Color.red);
			}			
		}
	}

	void OnMouseOver()
	{
		if (Input.GetMouseButtonUp(0))
		{
			if (powerLevel == 0)
			{
				windPower = windPower1;
				powerLevel = 1;
				pT1A.SetActive(true);
				pT1.SetActive(false);
				wind.Play();
			}
			else if (powerLevel == 1)
			{
				windPower = windPower2;
				powerLevel = 2;
				pT2A.SetActive(true);
				pT2.SetActive(false);
			}
			else if (powerLevel == 2)
			{
				windPower = windPower3;
				powerLevel = 3;
				pT3A.SetActive(true);
				pT3.SetActive(false);
			}
			else if (powerLevel == 3)
			{
				windPower = windPower0;
				powerLevel = 0;
				pT1A.SetActive(false);
				pT1.SetActive(true);
				pT2A.SetActive(false);
				pT2.SetActive(true);
				pT3A.SetActive(false);
				pT3.SetActive(true);
				wind.Stop();
			}
		}
	}
}
