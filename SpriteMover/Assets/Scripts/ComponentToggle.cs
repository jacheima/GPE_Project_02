using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentToggle : MonoBehaviour {

    private ShipController ship; //I am setting a variable for the ShipController component on the player

	// Use this for initialization
	void Start () {
        ship = GetComponent<ShipController>(); //I am getting the component so that I can change it
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P)) //If p is pressed
        {
            ship.enabled = !ship.enabled; //enable/disable the component. This works by changing it to whatever it is not.
        }

	}


}

//https://unity3d.com/learn/tutorials/topics/scripting/enabling-and-disabling-components
//I used the above link to learn how to enable and disable components