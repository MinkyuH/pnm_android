using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameController : MonoBehaviour {

    public static GameController instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollspeed = -1.5f;
    private int score = 0;
    public Text scoreText;

	// Use this for initialization

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

	public void Score()
    {
	    if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score: " + score.ToString(); 
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}


    public void UserDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }

     
}
