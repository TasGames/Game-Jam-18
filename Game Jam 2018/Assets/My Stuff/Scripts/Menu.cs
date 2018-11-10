using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour 
{
	public static bool isPaused = false;
	[SerializeField] protected GameObject pauseMenu;

	void Update()
	{
		if (isPaused == false)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenu.SetActive(false);
            if (GameEnd.gameOver == false)
                Time.timeScale = 1f;
        }
	}

	public void Play()
	{
		SceneManager.LoadScene("Main");
		Goal.score = 0;
		Spawner.goalSpawned = false;
		isPaused = false;
		GameEnd.gameOver = false;
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
        }
        else
        {
			isPaused = false;
        }
    }
}
