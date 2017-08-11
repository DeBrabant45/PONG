using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour
{
    private Transform Player;

	public void OnTriggerEnter2D (Collider2D colInfo)
    {
        Player = GameObject.Find("Player1").transform;

        if (colInfo.name == "Ball")
        {
			GameManager.Score (this.gameObject);
			GetComponent<AudioSource> ().pitch = Random.Range(0.5f, 0.8f);
			GetComponent<AudioSource> ().Play ();
			colInfo.gameObject.SendMessage ("ResetBall");

            Player.gameObject.SendMessage("PlayerReset");

        }
	}
 }

