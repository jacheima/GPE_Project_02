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

    public float enemyShipRotationSpeed;
    public Vector3 enemyShipSpeed;

    private float asteroidsInFeild;

    public GameObject largeAsteroid;

    public float spawnLocationNumber;

    public static gameManager instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.

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

	    spawnLocationNumber = Random.Range(1, 5);
	    SpawnAsteroids();
	}

    void SpawnAsteroids()
    {
        if (spawnLocationNumber == 1 && asteroidsInFeild < 1)
        {
            Instantiate(largeAsteroid, spawn1.transform.position, spawn1.transform.rotation);
            asteroidsInFeild++;
        }

        if (spawnLocationNumber == 2 && asteroidsInFeild < 1)
        {
            Instantiate(largeAsteroid, spawn2.transform.position, spawn2.transform.rotation);
            asteroidsInFeild++;
        }
        if (spawnLocationNumber == 3 && asteroidsInFeild < 1)
        {
            Instantiate(largeAsteroid, spawn3.transform.position, spawn3.transform.rotation);
            asteroidsInFeild++;
        }
        if (spawnLocationNumber == 4 && asteroidsInFeild < 1)
        {
            Instantiate(largeAsteroid, spawn4.transform.position, spawn4.transform.rotation);
            asteroidsInFeild++;
        }
    }
}
