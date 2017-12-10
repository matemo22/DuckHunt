using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIControl : MonoBehaviour {

	public void StartGame(string startGame)
	{
		SceneManager.LoadScene(startGame);
	}

	public void Score(string score)
	{

	}

	public void exit( )
	{
		Debug.Log("Bye bye");
		Application.Quit();
	}

	public void MENU_ACTION_GotoPage(string mainMenu)
	{
		SceneManager.LoadScene(mainMenu);
	}

}
