using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public GameObject scoreScreen;
	public GameObject gameOver;
	public GameObject replayButton;
	public static int score = 0;
	public static int highScore = 0;
	public Text txt;
	
	void OnGUI()
	{
		GUI.Label(new Rect(40,40,120,40), "Score: " + score);
	}
	
    // Start is called before the first frame update
    void Start()
    {
        scoreScreen.GetComponent<Renderer>().enabled = false;
		replayButton.gameObject.SetActive(false);
		gameOver.GetComponent<Renderer>().enabled = false;
		txt.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
		if(score > highScore)
		{
			highScore = score;
		}
		
		if(newPlayerMovement.gameOver == true)
		{
			txt.text = highScore.ToString();
			scoreScreen.GetComponent<Renderer>().enabled = true;
			replayButton.gameObject.SetActive(true);
			gameOver.GetComponent<Renderer>().enabled = true;
			txt.gameObject.SetActive(true);
		}
		
    }
}
