using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void QuitButton() 
	{
	Application.Quit();
	Debug.Log("Game Closed");
	}

	public void StartGame()
	{
	SceneManager.LoadScene("Beach");
	}
	public void BackToMain()
	{
	SceneManager.LoadScene("Main Menu");
	}
}
