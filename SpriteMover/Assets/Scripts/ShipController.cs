 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    public Vector2 center = new Vector2(0.0f, 0.0f);
    private Transform ship;
    public float speed;


	// Use this for initialization
	void Start () {
        ship = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) //if the user presses left or right shift
        {
	        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) //and if the user presses the left arrow or a key
	        {
	            Vector2 pos = transform.position; //set the current position to a vector variable
	            pos.x--; //decrement the position on the x axis by 1 moving the sprite left one sprite
	            transform.position = pos; //set the new position to the variable
                
	        }

	        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))  //if the user presses right arrow or d key
            {
                Vector2 pos = transform.position; //set the current position to a vector variable
                pos.x++; //increment the position by 1 on the x axis moving the sprite to the right one unit
                transform.position = pos; //set the new position to the variable
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))  //if the user presses the up arrow or the w key
            {
                Vector2 pos = transform.position;  //set the current position to a vector variable
                pos.y++; //increment the position by 1 on the y axis moving the sprite up one unit
                transform.position = pos;

            }
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))  //if the user presses the down arrow or the s key
            {
                Vector2 pos = transform.position; //set the current position to a vector variable
                pos.y--;  //decrement the position by 1 on the y axis moving the player down one unit
                transform.position = pos;

            }

        }
	    else //Otherwise
	    {
	        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) // if the player presses the left arrow or the a key
	        {
                ship.position = ship.position + (Vector3.left * speed); //the sprite position and add the vector left times the speed to move the sprite
            }

	        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))  // if the player presses the right arrow or d key
	        {
                ship.position = ship.position + (Vector3.right * speed);  //the sprite position and add the vector right times the speed to move the sprite
            }
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))  //if the player presses the up arrow or the w key
            {
                ship.position = ship.position + (Vector3.up * speed);  //the sprite position and add the vector up times the speed to move the sprite
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))  //if the player presses the down arrow or the s key
            {
                ship.position = ship.position + (Vector3.down * speed);  //the sprite position and add the vector down times the speed to move the sprite
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = center;

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.SetActive(false);
        }
	    
	}
}

