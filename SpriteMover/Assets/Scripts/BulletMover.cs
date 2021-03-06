﻿//BulletMover
//Programmer: Jacquelynne Heiman
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour {
    public float speed;  //public variable for speed, can be changed in the unity inspector
    private Rigidbody2D rb;  //The rigidbody attached to the bullet

    public float bulletDestroy = 2.0f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>(); //get the component
        rb.velocity = transform.up * speed;  //transform the bullet in the direction the player is facing at the set speed
        Destroy(gameObject, bulletDestroy);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
