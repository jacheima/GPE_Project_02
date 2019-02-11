using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 1;

    

    void Start()
    {
        //get the rigidbody component
        rb = GetComponent<Rigidbody2D>();
        //move the asteroid in the direction of the player at the time it was spawned
        Vector3 moveDir = (gameManager.instance.player.transform.position - transform.position);
        transform.position += moveDir * speed * Time.deltaTime;

    }

    void Update()
    {
        
    }
}

