using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour 
{

	// Use this for initialization
	public void LoadLevel(string name)
	{
		SceneManager.LoadScene(name);
		//Debug.Log ("Level load Requested for: " + name);
	}

	public static void LoadWL(string name)
	{
		GameManager.playerScore01 = 0;
		GameManager.playerScore02 = 0;
		SceneManager.LoadScene (name);

	}		

	public void QuitRequest ()
	{
		Debug.Log ("Quit Game!");
		Application.Quit();
	}

	//public static void LoadNextLevel()
	//{
		//SceneManager.LoadScene(Application.loadedLevel + 1);
	//}


}
