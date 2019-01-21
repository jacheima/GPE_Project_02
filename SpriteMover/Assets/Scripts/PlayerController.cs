using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed = 0.03f;
    bool faceRight = true;
    

    Animator anim;

    // Use this for initialization
    void Start ()
    {

        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", Mathf.Abs(move) );

        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (move > 0 && !faceRight)
        {
            Face();
        }
        else if (move < 0 && faceRight)
        {
            Face();
        }
    }

    void Face()
    {
        faceRight = !faceRight;
        Vector3 sca = transform.localScale;
        sca.x *= -1;
        transform.localScale = sca;
    }
    
}



//I used this site to help me on how to move the sprite (https://answers.unity.com/questions/667641/how-do-i-move-my-2d-object-using-arrow-keys-also-h.html)

/*
 *
 *
 * //This section handles sprite movement and facing the sprite in the direction he is moving. 


    Vector3 sca = this.transform.localScale;    // this statement gets the scale of the sprite.
    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) // if a is pressed or left arrow is press
    {
        Vector3 pos = this.transform.position; // this statement gets the position of the sprite
        pos.x--; //this decrements the position value at x by 1 and moves the sprite to the left
        this.transform.position = pos; // set the new position
        if (sca.x > 0) // and the scale of x is greater than 0
        {
            sca.x *= -1; //multiply the current scale by -1
            this.transform.localScale = sca; //set the new scale
        }
    }

    if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))   // if d is pressed or right arrow is pressed
    {
        Vector3 pos = this.transform.position; // this statement gets the position of the sprite
        pos.x++;  // this increments the position value of x by 1 and moves the sprite to the right
        this.transform.position = pos;  //set the new position
        if (sca.x < 0)  //and if the scale of x is less than 0
        {
            sca.x *= -1;  //multiply the scale of x by -1
            this.transform.localScale = sca;  //set the new scale 
        }
    }
 *
 *
 *
 *
 *
 */

