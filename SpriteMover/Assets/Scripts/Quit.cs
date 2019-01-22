using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) //if the user presses the escape key
        {
            Application.Quit(); //the application will quit
            Debug.Log("I'm quitting"); //this is a debug that prints "I'm Quitting" to the console for testing.
        }
	}
}
