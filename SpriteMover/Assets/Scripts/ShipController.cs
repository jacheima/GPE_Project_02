 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    public Vector2 center = new Vector2(0.0f, 0.0f);
    private Transform ship;
    public float speed;
    public GameObject bullet;
    public Transform shotSpawn;


	// Use this for initialization
	void Start () {
        ship = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        
	    
	}
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) // if the player presses the left arrow or the a key
        {
            transform.Rotate(new Vector3(0f, 0f, 90f) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))  // if the player presses the right arrow or d key
        {
            transform.Rotate(new Vector3(0f, 0f, -90f) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))  //if the player presses the up arrow or the w key
        {
            transform.position += transform.up * speed;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, shotSpawn.position, shotSpawn.rotation);

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.SetActive(false);
        }
    }
}

