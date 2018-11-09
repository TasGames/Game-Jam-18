using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindBlockMovement : MonoBehaviour 
{
	[SerializeField] protected bool isHorizontal;
	[SerializeField] protected float movementRange;

	float distance = 28.0f;

	void Start()
	 {
		
	}
	
	void Update() 
	{
		
	}

	void OnMouseDrag()
	{
		Vector3 mousePos;
		//Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);

		if (isHorizontal == true)
			mousePos = new Vector3(Input.mousePosition.x, 940.0f, distance);
		else
			mousePos = new Vector3(940.0f, Input.mousePosition.y, distance);


		Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);
		transform.position = objPos;
	}

}
