using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float largeAsteroidSpeed = 0.6f;
    public float smallAsteroidSpeed = 0.3f;

    private Vector3 moveDir;

    public GameObject smallAsteroid;

    private gameManager gameManager;
    

    void Start()
    {
        //get the rigidbody component
        rb = GetComponent<Rigidbody2D>();
        //move the asteroid in the direction of the player at the time it was spawned
        moveDir = (gameManager.instance.player.transform.position - transform.position);
        

    }

    void Update()
    {
        if (tag.Equals("Large Asteroid"))
        {
            transform.position += moveDir * largeAsteroidSpeed * Time.deltaTime;
        }
        else
        {
            transform.position += moveDir * smallAsteroidSpeed * Time.deltaTime;
        }
    }
        


    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "bullet")
        {
            //destroy the bullet
            Destroy(c.gameObject);

            //if large asteroid spawn new ones
            if (tag.Equals("Large Asteroid"))
            {
                Instantiate(smallAsteroid, new Vector3(transform.position.x - 1f, transform.position.y - 1f, 0),
                    Quaternion.Euler(0, 0, 90));

                Instantiate(smallAsteroid, new Vector3(transform.position.x + 1f, transform.position.y + 1f, 0),
                    Quaternion.Euler(0, 0, 0));

                gameManager.instance.SplitAsteroid();
            }
            else
            {
                gameManager.instance.DecrementAsteroids();
                
            }

            //Increment Player Score
            gameManager.instance.IncrementScore();

            //Destroy current asteroid
            Destroy(gameObject);

        }

        


    }
}

