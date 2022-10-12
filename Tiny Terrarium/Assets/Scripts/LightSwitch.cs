using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour {

	// referenses to controlled game objects
	public GameObject off, on;

	// variable contains which avatar is on and active
	int isLightOn = 1;

	// Use this for initialization
	void Start () {

		// anable first avatar and disable another one
		off.gameObject.SetActive (true);
		on.gameObject.SetActive (false);
	}

	// public method to switch avatars by pressing UI button
	public void Switch()
	{

		// processing isLightOn variable
		switch (isLightOn) {

		// if the first avatar is on
		case 1:

			// then the second avatar is on now
			isLightOn = 2;

			// disable the first one and anable the second one
			off.gameObject.SetActive (false);
			on.gameObject.SetActive (true);
			break;

		// if the second avatar is on
		case 2:

			// then the first avatar is on now
			isLightOn = 1;

			// disable the second one and anable the first one
			off.gameObject.SetActive (true);
			on.gameObject.SetActive (false);
			break;
		}
			
	}
}
