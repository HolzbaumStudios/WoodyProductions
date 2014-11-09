using UnityEngine;
using System.Collections;

public class runningScript : MonoBehaviour {

	//----------------------------------------------------- PUBLIC VARIABLES -----------------------------------------------------//
	bool taste = true; // true = q , false = w


	//----------------------------------------------------- START -----------------------------------------------------//
	// Use this for initialization
	void Start () {
	
	}

	//----------------------------------------------------- MAIN -----------------------------------------------------//
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Q)) {

			//Debug.Log ("Taste Q gedrückt!");
			if(taste) {
				//Debug.Log ("Ich bewege mich Q");
				Movement ();
				taste = false;
			}
		}
		if(Input.GetKeyDown (KeyCode.W)) {
			//Debug.Log ("Taste W gedrückt!");
			if(!taste) {
				//Debug.Log ("Ich bewege mich W");
				Movement();
				taste = true;
			}
		}
	}

	//----------------------------------------------------- FUNCTIONS -----------------------------------------------------//
	void Movement () {
		transform.Translate (0, 0, 10 * Time.deltaTime);
	}
}
