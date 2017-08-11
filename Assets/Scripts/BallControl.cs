using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour
{

	private float ballSpeed = 100;
	private float randomNumber;
	private float velocityY;
	private float velocityX;
	private Rigidbody2D rb2D;	// The Rigidbody inside our object
	private Transform trfm;		// The Transform inside our object

	// Use this for initialization
	void Start ()
    {

		Invoke("StartBall",2.0f);﻿
		
	}

	// Update is called once per frame
	void Update ()
    {
		rb2D = GetComponent<Rigidbody2D> ();
		velocityX = rb2D.velocity.x;

		if (velocityX < 19 && velocityX > -19 && velocityX != 0)
        {
			if (velocityX > 0)
            {
				velocityX = 24;
			}
            else
            {
				velocityX = -24;
			}
				
			Debug.Log ("Velocity before" + velocityX);
			Debug.Log ("Velocity after" + rb2D.velocity.x);
	
		}
	}

	// Ball Velocity upon hit
	public void OnCollisionEnter2D (Collision2D colInfo)
    {
		rb2D = GetComponent<Rigidbody2D> ();
		velocityY = rb2D.velocity.y;

		if (colInfo.collider.tag == "Player")
        {
			rb2D.velocity = (new Vector2 (rb2D.velocity.x, velocityY / 2 + colInfo.collider.GetComponent<Rigidbody2D> ().velocity.y / 3));
			GetComponent<AudioSource> ().pitch = Random.Range(0.8f, 1.2f);
			GetComponent<AudioSource> ().Play ();
		}	
	}

	// To reset Ball after a score
	void ResetBall ()
    {
		rb2D.velocity = new Vector2 (0, 0);
		transform.position = new Vector2 (0, 0);

		Invoke ("StartBall", 5.0f);
	}	

	// Setting a two second wait for the ball
	void StartBall ()
    {
		rb2D = GetComponent<Rigidbody2D> ();   // Getting Access to the Rigidbody
		randomNumber = Random.Range (0, 2);   

		if (randomNumber <= 0.5) {
			rb2D.AddForce(new Vector2 (ballSpeed, 10));
		}
		else
        {
			rb2D.AddForce(new Vector2 (-ballSpeed, -10));
		}
  	}
}