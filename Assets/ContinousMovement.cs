using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinousMovement : MonoBehaviour
{
	public float pipeSpeed = -3f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(newPlayerMovement.gameOver == false)
		{
			var vel = GetComponent<Rigidbody2D> ().velocity;
			vel.x = pipeSpeed;
			GetComponent<Rigidbody2D>().velocity = vel;
		}
		else
		{
			pipeSpeed = 0;
			var vel = GetComponent<Rigidbody2D> ().velocity;
			vel.x = pipeSpeed;
			GetComponent<Rigidbody2D>().velocity = vel;
		}
    }
}
