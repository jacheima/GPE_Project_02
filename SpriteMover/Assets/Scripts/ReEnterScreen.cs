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
        if (transform.position.y > 14.35)
        {
            transform.position = new Vector3(transform.position.x, -14.35f, 0);
        }

        if (transform.position.y < -14.35)
        {
            transform.position = new Vector3(transform.position.x, 14.35f, 0);
        }
        if (transform.position.x > 27.2)
        {
            transform.position = new Vector3(-27.2f, transform.position.x, 0);
        }
        if (transform.position.x < -27.2)
        {
            transform.position = new Vector3(27.2f, transform.position.x, 0);
        }
    }
}
