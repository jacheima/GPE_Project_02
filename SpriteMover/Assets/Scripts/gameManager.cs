using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class gameManager : MonoBehaviour
{

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;
    public GameObject player;
    public GameObject largeAsteroid;
    public GameObject enemyShip;

    
    public float asteroidsInField;
    public float spawnLocationNumber;
    public float enemyShipSpeed = .08f;
    public float enemyShipRotationSpeed = .08f;

    public int score;

    



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

    }
	// Update is called once per frame
	void Update ()
	{

	    spawnLocationNumber = Random.Range(1, 6);
	    SpawnAsteroids();
	}

    void SpawnAsteroids()
    {
        if (spawnLocationNumber == 1 && asteroidsInField < 3)
        {
            Instantiate(largeAsteroid, spawn1.transform.position, spawn1.transform.rotation);
            asteroidsInField++;
        }

        if (spawnLocationNumber == 2 && asteroidsInField < 3)
        {
            Instantiate(largeAsteroid, spawn2.transform.position, spawn2.transform.rotation);
            asteroidsInField++;
        }
        if (spawnLocationNumber == 3 && asteroidsInField < 3)
        {
            Instantiate(largeAsteroid, spawn3.transform.position, spawn3.transform.rotation);
            asteroidsInField++;

        }
        if (spawnLocationNumber == 4 && asteroidsInField < 3)
        {
            Instantiate(largeAsteroid, spawn4.transform.position, spawn4.transform.rotation);
            asteroidsInField++;
        }
        if (spawnLocationNumber == 5 && asteroidsInField < 3)
        {
            Instantiate(enemyShip, spawn4.transform.position, spawn4.transform.rotation);
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
        score++;
    }

    public void DecrementAsteroids()
    {
        asteroidsInField--;
    }
}
