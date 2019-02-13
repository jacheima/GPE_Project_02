using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    private float angle;
    
    private Rigidbody2D rb;
    private Vector3 direction;

	// Use this for initialization
	void Start () {
	    //get the rigidbody component
	    rb = GetComponent<Rigidbody2D>();
	    

    }
	
	// Update is called once per frame
	void Update ()
	{
        direction = gameManager.instance.player.transform.position - transform.position; direction.Normalize(); float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
	    transform.rotation = Quaternion.Euler(0f, 0f, angle);transform.Translate(Time.deltaTime * gameManager.instance.enemyShipSpeed, 0, 0);

    }
}
