using System.Collections;
using System.Collections.Generic;
using UnityEditor;
//using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    //get a reference to the rigidbody
    private Rigidbody2D rb;
    //set the large and small asteroid speeds
    public float largeAsteroidSpeed = 0.6f;
    public float smallAsteroidSpeed = 0.3f;

    //the move direction for the asteroids
    private Vector3 moveDir;

    //reference to the smallAsteroid gameObject 
    public GameObject smallAsteroid;

    //reference to the gameManager
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
        //if the tag is large asteroid
        if (tag.Equals("Large Asteroid"))
        {
            //move the asteroid in the moveDirection times the asteroid speed times the time
            transform.position += moveDir * largeAsteroidSpeed * Time.deltaTime;
        }
        //otherwise
        else
        {
            //move the small asteroid in the movedir times the small asteroid speed time the time
            transform.position += moveDir * smallAsteroidSpeed * Time.deltaTime;
        }
    }
        


    void OnCollisionEnter2D(Collision2D c)
    {
        //if the game objects tag is bullet
        if (c.gameObject.tag == "bullet")
        {
            //destroy the bullet
            Destroy(c.gameObject);

            //if large asteroid spawn new ones
            if (tag.Equals("Large Asteroid"))
            {
                //instatiate a small asteroid off set of the large asteroid position by 1 in the negative direction
                Instantiate(smallAsteroid, new Vector3(transform.position.x - 1f, transform.position.y - 1f, 0),
                    Quaternion.Euler(0, 0, 90));

                //instantiate a small asteroid off set of the large asteroid position by 1 in the positive direction
                Instantiate(smallAsteroid, new Vector3(transform.position.x + 1f, transform.position.y + 1f, 0),
                    Quaternion.Euler(0, 0, 0));

                //go to the function SplitAsteroid in the gameManager script
                gameManager.instance.SplitAsteroid();
            }
            //otherwise
            else
            {
                //go to the Decrement Asteroids function in the gameManager script
                gameManager.instance.DecrementAsteroids();
                
            }

            //Increment Player Score
            gameManager.instance.IncrementScore();

            //Destroy current asteroid
            Destroy(gameObject);

        }

        


    }
}

