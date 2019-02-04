using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour {

    public GameObject smallAsteroid;

    private GameController gameController;

	// Use this for initialization
	void Start () {

        //Reference to the game controller and the script
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");

        gameController = gameControllerObject.GetComponent<GameController>();

        //Move asteroid in the direction it is facing
        GetComponent<Rigidbody2D>().AddForce(transform.up * Random.Range(-50.0f, 150.0f));

        //Give a random velocity/rotation
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-0.0f, 90.0f);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("bullet"))
        {
            //destroy bullet
            Destroy(collision.gameObject);

            //If the big asteroids spawn new ones
            if (tag.Equals("Large Asteroid"))
            {
                //Spawn small asteroids
                Instantiate(smallAsteroid, new Vector3(transform.position.x - .5f, transform.position.y - .5f, 0), Quaternion.Euler(0, 0, 90));

                Instantiate(smallAsteroid, new Vector3(transform.position.x + .5f, transform.position.y + .5f, 0), Quaternion.Euler(0, 0, 0));
            }
            else
            {
                //A small asteroid is destroyed
                gameController.DecrementAsteroids();
            }

            //Add to the score
            gameController.IncrementScore();

            //Destroy the current asteroid
            Destroy(gameObject);
            
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
