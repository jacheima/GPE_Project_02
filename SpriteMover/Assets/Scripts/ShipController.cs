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


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetKeyDown(KeyCode.Space) && Time.time > _nextFire)
	    {
	        _nextFire = Time.time + FireRate;
	        //GameObject clone =           
	        Instantiate(Shot, ShotSpawn.position, ShotSpawn.rotation);
	        //as GameObject;
	    }
	    
	}
    private void FixedUpdate()
    {
        // if the player presses the left arrow or the a key
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) 
        {
            //This rotates the ship on the z axis 90 degrees over 1 second. This allows for a smoother rotate in a positive direction.
            transform.Rotate(new Vector3(0f, 0f, 90f) * Time.deltaTime);  
        }

        // if the player presses the right arrow or d key
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))  
        {
            //This rotates the ship on the z axis 90 degrees over 1 second. This allows for a smoother rotate in a negative direction.
            transform.Rotate(new Vector3(0f, 0f, -90f) * Time.deltaTime); 
        }

        //if the player presses the up arrow or the w key
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))  
        {
            // This lets the player move forward in the direction they are facing
            transform.position += transform.up * Speed;
        }

        //if the player press space bar
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
          //this is where the shooting mechanic will go
        }

        // if the player presses q
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //the game object with be set to inactive
            gameObject.SetActive(false); 
        }
    }
}

