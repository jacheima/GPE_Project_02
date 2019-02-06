using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public GameObject asteroid;

    private int score;
    private int highScore;
    private int asteroidsRemaining;
    private int lives;
    private int wave;
    private int increaseEachWave = 4;

    public Text scoreText;
    public Text livesText;
    public Text waveText;
    public Text highScoreText;

    // Use this for initialization
    void Start () {
        highScore = PlayerPrefs.GetInt("highscore", 0);
        BeginGame();
	}
	
	// Update is called once per frame
	void Update () {
		
        //Quit if player presses escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}

    void BeginGame()
    {
        score = 0;
        lives = 3;
        wave = 1;

        //prep the hud
        scoreText.text = "Score: " + score;
        highScoreText.text = "High Score: " + highScore;
        livesText.text = "Lives: " + lives;
        waveText.text = "Wave: " + wave;

        SpawnAsteroids();
    }

    void SpawnAsteroids()
    {
        DestroyExistingAsteroids();

        //Calculate how many asteroids to spawn
        //If any asteroids are left over from the previous game, subtract them
        asteroidsRemaining = (wave * increaseEachWave);

        int i;

        for (i = 0; i < asteroidsRemaining; i++)
        {
            //Spawn asteroid
            Instantiate(asteroid, new Vector3(Random.Range(-13.2f, 13.2f), Random.Range(-23.5f, 23.5f), 0), Quaternion.Euler(0, 0, Random.Range(-0.0f, 359.0f)));
        }

        waveText.text = "Wave: " + wave;
    }

    public void IncrementScore()
    {
        score++;

        scoreText.text = "Score: " + score;

        if (score > highScore)
        {
            highScore = score;
            highScoreText.text = "High Score: " + highScore;

            //Save the new high score
            PlayerPrefs.SetInt("highscore", highScore);


        }

        if (asteroidsRemaining < 1)
        {
            wave++;
            SpawnAsteroids();
        }
    }

    public void DecrementLives()
    {
        lives--;
        livesText.text = "Lives: " + lives;

        //Does the player have more lives?
        if (lives < 1)
        {
            //restart the game
            BeginGame();
        }
    }

    public void DecrementAsteroids()
    {
        asteroidsRemaining--;
        IncrementScore();
        
    }

    public void SplitAsteroid()
    {
        //split big asteroids into two small ones
        asteroidsRemaining += 2;
    }

    void DestroyExistingAsteroids()
    {
        GameObject[] asteroids = GameObject.FindGameObjectsWithTag("Large Asteroid");

        foreach (GameObject current in asteroids)
        {
            GameObject.Destroy(current);
        }

        GameObject[] asteroids2 = GameObject.FindGameObjectsWithTag("Small Asteroid");

        foreach (GameObject current in asteroids2)
        {
            GameObject.Destroy(current);
        }
    }
}
