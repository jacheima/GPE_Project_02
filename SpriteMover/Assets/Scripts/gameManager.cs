using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameManager : MonoBehaviour
{
    //the references to the spawn points, the player, and the enemies
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;
    public GameObject player;
    public GameObject largeAsteroid;
    public GameObject smallAsteroid;
    public GameObject enemyShip;

    //the number of asteroids currently spawned, the spawn location number that is randomly generated and saved here, the enemy ship speed and rotation speed
    public float asteroidsInField;
    public float spawnLocationNumber;
    public float enemyShipSpeed = .08f;
    public float enemyShipRotationSpeed = .08f;
    
    //score and lives variables
    public int score = 0;
    public int lives = 3;

    //these hold all the text elements on the canvas
    public Text scoreText;
    public Text livesText;
    public Text playagain;
    public Text yes;
    public Text no;

    //a boolean to tell the game if it has ended or not. Used for changing player movement and calling the endgame functions
    public bool isGameEnded = false;

    public float randNumGenLow = 1;
    public float randNumGenHigh = 6;
    



    //Static instance of GameManager which allows it to be accessed by any other script.
    public static gameManager instance = null;

    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

        // Use this for initialization
    
		
	}

    void Start()
    {
        //Go to the begin game function
        BeginGame();
    }
    public void BeginGame()
    {
        //set score to 0, lives to 3 and asteroids in the field to 0
        score = 0;
        lives = 3;
        asteroidsInField = 0;

        //prepare the HUD
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
        playagain.text = " ";
        yes.text = " ";
        no.text = " ";

        //set isgameended to false
        isGameEnded = false;
        
        //go to the spawn asteroids function
        SpawnAsteroids();

    }
    // Update is called once per frame
    
    
    void SpawnAsteroids()
    {
        // if the number genereate equals one and there are less than 3 asteroids in the field
        if (spawnLocationNumber == 1 && asteroidsInField < 3)
        {
            //put another large asteroid in the field
            Instantiate(largeAsteroid, spawn1.transform.position, spawn1.transform.rotation);
            //increment the number of asteroids in field variable
            asteroidsInField++;
        }
        //if the number generated equals 2 and there are less than 3 asteroids in the field
        if (spawnLocationNumber == 2 && asteroidsInField < 3)
        {
            //put another large asteroid in the field
            Instantiate(largeAsteroid, spawn2.transform.position, spawn2.transform.rotation);
            //increment the number of asteroids currently in field
            asteroidsInField++;
        }
        //if the number generated equals 3 and there are less than 3 asteroids in the field
        if (spawnLocationNumber == 3 && asteroidsInField < 3)
        {
            //put another large asteroid in the field
            Instantiate(largeAsteroid, spawn3.transform.position, spawn3.transform.rotation);
            //increment the number of asteroids currently in the field
            asteroidsInField++;

        }
        //if the number generated equals 4 and there are less than 3 asteroids in the field
        if (spawnLocationNumber == 4 && asteroidsInField < 3)
        {
            //put another large asteroid in the field
            Instantiate(largeAsteroid, spawn4.transform.position, spawn4.transform.rotation);
            //increment the number of asteroids currently in the field
            asteroidsInField++;
        }
        //if the number generated equals 5 and there are less than 3 asteroids in the field
        if (spawnLocationNumber == 5 && asteroidsInField < 3)
        {
            //put an enemy ship in the field
            Instantiate(enemyShip, spawn4.transform.position, spawn4.transform.rotation);
            //increment the number of asteroids currently in the field
            asteroidsInField++;
        }
    }


    public void SplitAsteroid()
    {
        //Add 1 asteroid to the asteroid remaining count
        asteroidsInField++;
    }

    public void IncrementScore()
    {
        //increment the score
        score++;
        //update the score text on the UI
        scoreText.text = "Score: " + score;
    }

    public void DecrementAsteroids()
    {
        //decrement the number of asteroids in the field
        asteroidsInField--;
    }
    public void DecrementLives()
    {
        //decrement the number of lives
        lives--;
        //update the text on the UI
        livesText.text = "Lives: " + lives;

        //if the number of lives is less than or equal to 0
        if (lives <= 0)
        {
            //set isGameEnded to true
            isGameEnded = true;
            //go to the endGame function
            endGame();
        }
        //otherwise, set the player location back to the center 
        else
        {
            //transform the players position back to the center of the screen
            player.transform.position = new Vector3(0, 0, 0);
            
        }
    }
    void RemoveEnimies()
    {
        //find all the asteroids with the tag large asteroid and add them to this array
        GameObject[] asteroids =
             GameObject.FindGameObjectsWithTag("Large Asteroid");
        //foreach element in the array destroy the gameobject
        foreach (GameObject current in asteroids)
        {
            GameObject.Destroy(current);
        }

        //find all the asteroids with the tag small asteroid and add them to this array
        GameObject[] asteroids2 =
            GameObject.FindGameObjectsWithTag("Small Asteroid");
        //foreach element in the array destroy the gameobject
        foreach (GameObject current in asteroids2)
        {
            GameObject.Destroy(current);
        }
        //find all the asteroids with the tag enemy ship and add them to this array
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy Ship");
        //foreach element in the array destroy the gameobject
        foreach (GameObject current in enemies)
        {
            GameObject.Destroy(current);
        }
        //go to the endGameCont function
        endGameCont();
    }


    void endGame()
    {
        
        //disbale spawn points
        spawn1.SetActive(false);
        spawn2.SetActive(false);
        spawn3.SetActive(false);
        spawn4.SetActive(false);
       
        //remove all enemies
        RemoveEnimies();
        

        

    }
    void endGameCont()
    {


        
        //remove the text elements on the Canvas
        scoreText.text = " ";
        livesText.text = " ";

        //show the end of the game text
        playagain.text = "You lost :( Want to play again?";
        yes.text = "Yes";
        no.text = "No";

        player.transform.position = new Vector3(0.61f, 0.27f, 0.0f);
    }
   

    void Update()
    {
        //pick a random number between 1 and 5 and save it to the SpawnLocationNumber variable
        spawnLocationNumber = Random.Range(1, 6);
        //go to the spawn asteroids function
        SpawnAsteroids();
    }
}
