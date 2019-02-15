using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    //the variable to hold the angle number
    private float angle;
    
    //reference to the rigidbody
    private Rigidbody2D rb;
    //vector 3 variable to hold the direction
    private Vector3 direction;

	// Use this for initialization
	void Start () {
	    //get the rigidbody component
	    rb = GetComponent<Rigidbody2D>();
	    

    }
	
	// Update is called once per frame
	void Update ()
	{
        //the direction equals the players position, which is being referenced through the gameManager minus the position of the enemy ship
        direction = gameManager.instance.player.transform.position - transform.position;
        //normalie the direction
        direction.Normalize();
        //the angle calculation
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //rotate the enemy ship to the angle
	    transform.rotation = Quaternion.Euler(0f, 0f, angle);
        //translate over a second times the shipspeed set in the game manager
        transform.Translate(Time.deltaTime * gameManager.instance.enemyShipSpeed, 0, 0);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if the enemy ship is collided with an object that has a tag called bullet
        if (collision.gameObject.tag.Equals("bullet"))
        {
            //destroy the bullet
            Destroy(collision.gameObject);
            //Destroy the enemy ship
            Destroy(gameObject);
            //Increment the score
            gameManager.instance.IncrementScore();

        }
    }
}
