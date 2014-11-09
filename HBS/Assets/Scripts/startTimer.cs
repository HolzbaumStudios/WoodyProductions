using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class startTimer : MonoBehaviour {

	//----------------------------------------------------- VARIABLES -----------------------------------------------------//
	float timer;
	int intTimer;
	bool timerStarted = false;
	string timerText;
	public GameObject timerObject;

	//----------------------------------------------------- START -----------------------------------------------------//
	// Use this for initialization
	void Start () {
		timer = 3;
	}

	//----------------------------------------------------- MAIN -----------------------------------------------------//
	// Update is called once per frame
	void Update () {
		if (!timerStarted) {
			if (Input.anyKeyDown) {
				//Debug.Log ("Taste gedrückt");
					timerStarted = true;
					gameObject.GetComponent<Text>().text = "3";
			}
		} else if (timerStarted) {
			timer -= Time.fixedDeltaTime;
			intTimer = (int)timer;
			if(timer <= -1){
				timerText = "";

			}else if(timer <= 0){
				timerText = "Los!!!";
				timerObject.SetActive(true);
			}else{
				timerText = (intTimer + 1).ToString ();
			}
			gameObject.GetComponent<Text>().text = timerText;
		}

	}
}
