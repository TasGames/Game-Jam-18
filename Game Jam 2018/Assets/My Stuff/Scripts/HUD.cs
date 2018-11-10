using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour 
{
	[SerializeField] protected Text scoreText;
	[SerializeField] protected Text highScoreText;
	protected int highScore;

	void Start()
	{
		PlayerPrefs.SetInt("Highscore", highScore);

	}
	void Update() 
	{
		scoreText.text = "Score: " + Goal.score;

		if (Goal.score > highScore)
        {
            highScore = Goal.score;
            PlayerPrefs.SetInt("Highscore", highScore);
		}
		
        highScoreText.text = "High-Score: " + PlayerPrefs.GetInt("Highscore", highScore);
	}
}
