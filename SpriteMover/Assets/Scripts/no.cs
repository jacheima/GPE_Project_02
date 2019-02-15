using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class no : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the player presses return and the isGameVariable is set to true
        if (Input.GetKey(KeyCode.Return) && gameManager.instance.isGameEnded == true)
        {
            //quit the game
            Application.Quit();
        }
    }
}
