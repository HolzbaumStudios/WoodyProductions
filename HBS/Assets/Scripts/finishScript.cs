using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class finishScript : MonoBehaviour {
	//----------------------------------------------------- PUBLIC VARIABLES -----------------------------------------------------//

	public GameObject finishMessage;
	public GameObject timerStop;
	public GameObject restartText;

	

	//----------------------------------------------------- FUNCTIONS -----------------------------------------------------//

	void OnTriggerEnter(Collider collision) {
		if (collision.gameObject.tag == "Player") {
			Debug.Log ("Ziel erreicht");
			finishMessage.SetActive (true);
			timerStop.SendMessage("Stop");
			restartText.GetComponent<Text>().enabled = true;
			timerStop.SendMessage("SetUpdate");
		}
	}

}
