using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour 
{

	public KeyCode moveUp;
	public KeyCode moveDown;

	private float speed = 10f;
    private Transform thePlayer1;
	private Transform thePlayer2;

	private Rigidbody2D rb2D; // The Rigidbody inside our object

	void Start ()
	{
		rb2D = GetComponent<Rigidbody2D>(); // Getting Access to the Rigidbody
        thePlayer1 = GameObject.Find("Player1").transform;
        thePlayer2 = GameObject.Find("Player2").transform;
    }
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (moveUp)) 
		{
			rb2D.velocity = new Vector2 (0,speed);
		}
		else if(Input.GetKey(moveDown)) {
			rb2D.velocity = new Vector2 (0,-speed);
		}
        else
        {
            rb2D.velocity = new Vector2(-0, 0);
        }
    }
    // To reset Ball after a score
    void PlayerReset () 
	{
        thePlayer1.position = new Vector2 (-9.683407f, 0);
        thePlayer2.position = new Vector2(9.683406f, -2.740383e-07f);
    }

}	