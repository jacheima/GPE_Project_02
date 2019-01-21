using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShipController : MonoBehaviour {

    public Vector2 center  =new Vector2(0.0f, 0.0f);
    public float speed;
    private Transform ship;


	// Use this for initialization
	void Start ()
	{
	    ship = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
	    {
	        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
	        {
	            Vector2 pos = transform.position;
	            pos.y--;
	            transform.position = pos;
	        }

	        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
	        {
	            Vector2 pos = transform.position;
	            pos.y++;
	            transform.position = pos;
	        }

	        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
	        {
	            Quaternion rot = transform.localRotation;
	            rot.z--;
	            transform.localRotation = rot;
	        }

	        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
	        {
	            Quaternion rot = transform.localRotation;
	            rot.z++;
	            transform.localRotation = rot;
	        }

        }
	    else
	    {
	        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
	        {
	            ship.position = ship.position + (Vector3.left * speed);
	        }

	        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
	        {
	            ship.position = ship.position + (Vector3.right * speed);
	        }

	        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
	        {
	            transform.Rotate(Vector3.forward * speed);
	        }
	        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
	        {
	            transform.Rotate(Vector3.back * speed);
	        }
        }

	    if (Input.GetKeyDown(KeyCode.Space))
	    {
	        transform.position = center;

	    }


	    
	}
}

