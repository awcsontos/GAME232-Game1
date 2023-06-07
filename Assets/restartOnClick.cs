using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartOnClick : MonoBehaviour
{
	public string next;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnMouseDown()
	{
		GameManager.score = 0;
		newPlayerMovement.gameOver = false;
		SceneManager.LoadScene(next);
	}
}
