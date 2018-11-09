using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameEnd : MonoBehaviour
 {
	[SerializeField] protected Text timerText;
	[SerializeField] protected float timerSize;
	protected float countdown;

	void Start() 
	{
		countdown = timerSize;
	}
	
	void Update() 
	{
		countdown -= Time.deltaTime;
		countdown = Mathf.Round(countdown * 100.0f) / 100.0f;

		timerText.text = "Countdown: " + countdown;
	}
}
