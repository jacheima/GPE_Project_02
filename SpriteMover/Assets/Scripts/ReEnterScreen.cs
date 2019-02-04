using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReEnterScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //teleport asteroids
        if (transform.position.y > 13.2)
        {
            transform.position = new Vector3(transform.position.x, -13.2f, 0);
        }

        if (transform.position.y < -13.2)
        {
            transform.position = new Vector3(transform.position.x, 13.2f, 0);
        }
        if (transform.position.x > 23.5)
        {
            transform.position = new Vector3(-23.5f, transform.position.x, 0);
        }
        if (transform.position.x < -23.5)
        {
            transform.position = new Vector3(23.5f, transform.position.x, 0);
        }
    }
}
