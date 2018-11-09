using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;


public class WindBlockMovement : MonoBehaviour 
{
	[SerializeField] protected float movementRange;
	[SerializeField] protected bool isHorizontal;

	protected float maxX;
	protected float maxZ;
	protected float minX;
	protected float minZ;

	float distance = 28.0f;

	void Start()
	{
		maxX = transform.position.x + movementRange;
		minX = transform.position.x - movementRange;

		maxZ = transform.position.z + movementRange;
		minZ = transform.position.z - movementRange;
	}

	void OnMouseDrag()
	{
		Vector3 mousePos;
		mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);

		Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);

		if (isHorizontal == true)
		{
			transform.position = new Vector3(objPos.x, transform.position.y, transform.position.z);

			if (transform.position.x > maxX)
				transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
			else if (transform.position.x <minX)
				transform.position = new Vector3(minX, transform.position.y, transform.position.z);
		}
		else
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, objPos.y);
		}
	}

}
