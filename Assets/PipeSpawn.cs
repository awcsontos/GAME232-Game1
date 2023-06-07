using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
	public Transform pipes;
	
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("putPipesUp", 0.2f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
		
	}
	
	void putPipesUp()
	{
		if(newPlayerMovement.gameOver == false)
		{
			float randY = Random.Range(-1.5f, 1.5f);
			Instantiate(pipes, new Vector3(0,randY,-3), Quaternion.identity);
		}
	}
}
