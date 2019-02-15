//Project 2: Ultimate Asteroids Tactical-Control
//Programmer: Jacquelynne Heiman
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{

    public float Speed;
    public GameObject Shot;
    public Transform ShotSpawn;
    public float FireRate;
    private float _nextFire;
    public float playerRotateSpeed = 90f;

    private gameManager GameManager;

    

    




	// Use this for initialization
	void Start ()
	{
	   
    }
	
	// Update is called once per frame
	void Update ()
	{
        //if the player presses space and the time is greater than next fire
	    if (Input.GetKeyDown(KeyCode.Space) && Time.time > _nextFire)
	    {
	        _nextFire = Time.time + FireRate;
	        //GameObject clone =           
	        Instantiate(Shot, ShotSpawn.position, ShotSpawn.rotation);
	        //as GameObject;
	    }
        // if the player presses the left arrow or the a key
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            //if the isGameEnded variable in the gameManager equals false
            if (gameManager.instance.isGameEnded == false)
            {
                //This rotates the ship on the z axis 90 degrees over 1 second. This allows for a smoother rotate in a positive direction.
                transform.Rotate(new Vector3(0f, 0f, playerRotateSpeed) * Time.deltaTime);
            }
            //otherwise
            else
            {
                //set the player location to:
                transform.position = new Vector3(-7.37f, .27f, 0.0f);
            }
            

        }

        // if the player presses the right arrow or d key
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D))
        {
            // if the isGameEnded variable in the gameManager is equal to false
            if (gameManager.instance.isGameEnded == false)
            {
                //This rotates the ship on the z axis 90 degrees over 1 second. This allows for a smoother rotate in a negative direction.
                transform.Rotate(new Vector3(0f, 0f, -playerRotateSpeed) * Time.deltaTime);
            }
            //otherwise
            else
            {
                //move the player to this location
                transform.position = new Vector3(0.61f, 0.27f, 0.0f);
            }
            
        }

        //if the player presses the up arrow or the w key
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && gameManager.instance.isGameEnded == false)
        {
            // This lets the player move forward in the direction they are facing
            transform.position += transform.up * Speed;
        }

        if (transform.position.y < -12.13 || transform.position.y > 12.13)
        {
            transform.position = new Vector3(0, 0, 0);
            gameManager.instance.DecrementLives();
        }
        if (transform.position.x < -25.43 || transform.position.x > 25.43)
        {
            transform.position = new Vector3(0, 0, 0);
            gameManager.instance.DecrementLives();
        }





    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        //if an object collides with the player that is not the bullet
        if (other.gameObject.tag != "bullet")
        {
            //move the ship to the center of the screen
            transform.position = new Vector3(0, 0, 0);

            //lose a life
            gameManager.instance.DecrementLives();
        }

    }

   
   

}

