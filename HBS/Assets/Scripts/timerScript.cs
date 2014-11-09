using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timerScript : MonoBehaviour {

	//----------------------------------------------------- VARIABLES -----------------------------------------------------//
	float timer = 0.00f;
	string timerText = "";
	bool status;
	bool update = false;

	// Use this for initialization
	void Start () {
		status = true;
	}

	// Update is called once per frame
	void Update () {
		if (status == true) {
			timer += Time.fixedDeltaTime;
			//Debug.Log (timer);
			timerText = timer.ToString ("0.00");
			gameObject.GetComponent<Text> ().text = timerText;
		}
		if (update == true && Input.GetKeyDown(KeyCode.R)) {
			Restart();
		}
	}

	public void Stop () {
		status = false;
	}

	public void SetUpdate () {
		update = true;
	}
	
	public void Restart () {
		timer = 0.00f;
		timerText = timer.ToString ("0.00");
		gameObject.GetComponent<Text> ().text = timerText;
		GameObject.Find("Paul").transform.position = new Vector3 (0,0,-23);
		Application.LoadLevel ("Landscape");
	}
}
