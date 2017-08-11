using UnityEngine;
using System.Collections;

public class AIControl : MonoBehaviour
{
	
	public Transform Ball;
	public bool Easy;
	public bool Medium;
	public bool Hard;

    //Use this for initialization
    void Start()
    {
		Ball = GameObject.Find ("Ball").transform;
    }  
		
    //Update is called once per frame
     void Update()
	{	
		AIDifficulty ();
	}
		
	void AIDifficulty ()
	{
		if (Easy == true)
		{
			transform.position = new Vector3 (9.683406f, Ball.position.y / 1.6f, 0);
		} 
		else if (Medium == true) 
		{
			transform.position = new Vector3 (9.683406f, Ball.position.y / 1.4f, 0);
		} 
		else if (Hard == true)
		{
			transform.position = new Vector3(9.683406f, Ball.position.y / 1f, 0);
		}
	}
}


