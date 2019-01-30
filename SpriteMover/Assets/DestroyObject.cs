using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

<<<<<<< HEAD
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
=======
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "asteroid" || other.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "player")
        {
            Destroy(gameObject);
        }
        
>>>>>>> 7d1c061c2d57fd85d1d1895f12d90133e214bc59
    }
}
