using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour 
{
	[SerializeField] protected GameObject pauseMenu;

	void Start() 
	{
		
	}
	
	void Update()
	{
		
	}

	void pauseIt()
    {
        if (Menu.isPaused == true)
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
}
