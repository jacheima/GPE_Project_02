using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yes : MonoBehaviour {

    public gameManager gameManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        //if the player press the return key and the isGameEnded variable is set to true
        if (Input.GetKey(KeyCode.Return) && gameManager.instance.isGameEnded == true)
        {
            Debug.Log("You pressed Return");
            //go to the BeginGame function in the gameManager
            gameManager.instance.BeginGame();
        }
    }
}
