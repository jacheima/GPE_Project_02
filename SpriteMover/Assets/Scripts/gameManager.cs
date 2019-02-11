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

    private float asteroidsInFeild;

    public GameObject largeAsteroid;

    public float spawnLocationNumber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

	    spawnLocationNumber = Random.Range(1, 5);
	    SpawnAsteroids();
	}

    void SpawnAsteroids()
    {
        if (spawnLocationNumber == 1 && asteroidsInFeild < 3)
        {
            Instantiate(largeAsteroid, spawn1.transform.position, spawn1.transform.rotation);
            asteroidsInFeild++;
        }

        if (spawnLocationNumber == 2 && asteroidsInFeild < 3)
        {
            Instantiate(largeAsteroid, spawn2.transform.position, spawn2.transform.rotation);
            asteroidsInFeild++;
        }
        if (spawnLocationNumber == 3 && asteroidsInFeild < 3)
        {
            Instantiate(largeAsteroid, spawn3.transform.position, spawn3.transform.rotation);
            asteroidsInFeild++;
        }
        if (spawnLocationNumber == 4 && asteroidsInFeild < 3)
        {
            Instantiate(largeAsteroid, spawn4.transform.position, spawn4.transform.rotation);
            asteroidsInFeild++;
        }
    }
}
