using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour 
{
	public static bool hasPlayed = false;
	public static bool isPaused;

	[SerializeField] protected GameObject pauseMenu;
	[SerializeField] protected GameObject startGO;
	[SerializeField] protected GameObject controlsGO;
	[SerializeField] protected GameObject playingGO;
	protected GameObject currentMenu;

	void Start()
	{
		if (hasPlayed == false)
		{
			startGO.SetActive(true);
			isPaused = false;
		}
		else
		{
			playingGO.SetActive(true);
			isPaused = false;
		}
	}

	public void Play()
	{
		if (hasPlayed == false)
			hasPlayed = true;

		SceneManager.LoadScene("Main");

		Goal.score = 0;
		Spawner.goalSpawned = false;
		GameEnd.gameOver = false;
	}

	public void Controls()
	{
		startGO.SetActive(false);
		controlsGO.SetActive(true);
	}

	public void Return()
	{
		controlsGO.SetActive(false);
		startGO.SetActive(true);
	}

	public void Quit()
	{
		Application.Quit();
	}

	public void pauseIt()
    {
        if (isPaused == false)
        {
			isPaused = true;
			pauseMenu.SetActive(true);
			Time.timeScale = 0f;
        }
        else
        {
			isPaused = false;
			pauseMenu.SetActive(false);
			Time.timeScale = 1f;
        }
    }

}
