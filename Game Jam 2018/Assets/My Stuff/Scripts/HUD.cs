using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour 
{
	[SerializeField] protected Text scoreText;
	void Update() 
	{
		scoreText.text = "Score: " + Goal.score;
	}
}
