using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newPlayerMovement : MonoBehaviour
{
	
	public float upwardVel = 3.0f;
	
	public static bool gameOver = false;
	public AudioClip flap;
	public AudioClip die;
    public AudioSource dragon;
	Animator dragonAnim;
	
    // Start is called before the first frame update
    void Start()
    {
        dragonAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && gameOver == false)
		{
			var vel = GetComponent<Rigidbody2D> ().velocity;
			vel.y = upwardVel;
			GetComponent<Rigidbody2D>().velocity = vel;
			dragon.PlayOneShot(flap);
		}
    }
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "scoreBox")
		{
			
		}
		else
		{
			dragon.PlayOneShot(die);
			dragonAnim.SetTrigger("Die");
			gameOver = true;
		}
	}
	
}
