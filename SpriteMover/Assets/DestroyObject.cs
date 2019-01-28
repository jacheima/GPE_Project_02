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
        
    }
}
