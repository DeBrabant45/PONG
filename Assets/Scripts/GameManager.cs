using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

	public static int playerScore01 = 0;
	public static int playerScore02 = 0;
	//private Transform theBall;
    public GUISkin theSkin;
	//private Transform playerReset;

    void Start ()
    {
		//theBall = GameObject.Find("Ball").transform;
		//playerReset = GameObject.Find ("Player1").transform;
    }

    // Score upon goal
    public static void Score(GameObject wallName)
    {
        if (wallName.name == "rightWall")
            playerScore01++;

        else
            playerScore02++; 
			ScoreLimit ();
    }

	public static void ScoreLimit()
	{
		if (playerScore01 == 8) 
		{
			LevelManager.LoadWL("Win");
		}
		else if (playerScore02 == 8)
		{
			LevelManager.LoadWL("Lose");
		}

	}

    // Reset Button	
    public void OnGUI()
    {
		//theBall = GetComponent<Transform> ();
		GUI.skin = theSkin;
		GUI.Label (new Rect (Screen.width / 2 - 150 - 13, 20, 100, 100), "" + playerScore01);
        GUI.Label (new Rect (Screen.width / 2 + 150 - 13, 20, 100, 100), "" + playerScore02);
	

		// Reset of the Score
		//if (GUI.Button (new Rect (Screen.width / 2 -121 / 2, 35, 121, 53), "RESET"))
        //{
			//playerScore01 = 0;
			//playerScore02 = 0;
   
			//Ball reset upon reset button
			//theBall = GameObject.Find("Ball").transform;
			//theBall.gameObject.SendMessage ("ResetBall");

            //playerReset.gameObject.SendMessage ("PlayerReset");

        }
	}
