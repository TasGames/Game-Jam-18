using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
	public static bool gameOver = false;
	[SerializeField] protected GameObject gameOverMenu;
	[SerializeField] protected Text timerText;
	[SerializeField] protected float timerSize;
	protected float countdown;
	protected bool continueC;

	void Start() 
	{
		countdown = timerSize;
		continueC = true;
	}
	
	void Update() 
	{
		if (continueC == true)
			countdown -= Time.deltaTime;
		else
			countdown = 0;

		countdown = Mathf.Round(countdown * 100.0f) / 100.0f;

		timerText.text = "Countdown: " + countdown;

		if (countdown <= 0 && continueC == true) 
		{
			gameOver = true;
			continueC = false;
		}

		if (gameOver == true)
		{
			gameOverMenu.SetActive(true);
			Time.timeScale = 0f;
		}
		else
		{
            gameOverMenu.SetActive(false);
            Time.timeScale = 1f;
		}
	}

}
