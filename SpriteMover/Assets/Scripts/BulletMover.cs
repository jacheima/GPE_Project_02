//BulletMover
//Programmer: Jacquelynne Heiman
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour {
    public float speed;  //public variable for speed, can be changed in the unity inspector
    private Rigidbody rb;  //The rigidbody attached to the bullet

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>(); //get the component
        rb.velocity = transform.up * speed;  //transform the bullet in the direction the player is facing at the set speed
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
