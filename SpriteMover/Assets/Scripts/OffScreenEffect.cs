using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffScreenEffect : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //destroy the game object if it leaves the screen
        if (transform.position.y > 13.2 || transform.position.y < -13.2)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > 23.5 || transform.position.x < -23.5)
        {
            Destroy(gameObject);
        }
    }

}
