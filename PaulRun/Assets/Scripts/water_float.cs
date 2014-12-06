using UnityEngine;
using System.Collections;

public class water_float : MonoBehaviour {
	
	bool waterUp = true; // Bool um die Wasserbewegung nach oben zu starten
	bool startMovement = false; // Bool um pro Wasserblock die Bewegung via Randomater starten zu lassen

	// Use this for initialization
	void Start () {
		StartCoroutine (StartWaterMovementRandom ());
	}
	
	// Update is called once per frame
	void Update () {
		// Wasserfloat oben
		if (startMovement == true) {
			if (waterUp == true) {
					transform.Translate (new Vector3 (0, 0.1f, 0) * Time.deltaTime);
					if (transform.position.y >= 0f) {
							waterUp = false;
					}
			} else if (waterUp == false) {
					transform.Translate (new Vector3 (0, -0.1f, 0) * Time.deltaTime);
					if (transform.position.y <= -0.2f) {
							waterUp = true;
					}
			}
		}
	}

	// Generiert einen Random Zeitwert und lässt die Blöcke wie WaterMovement random starten.
	IEnumerator StartWaterMovementRandom (){
		float randomDelay = Random.Range (0f, 1.5f);
		yield return new WaitForSeconds (randomDelay);
		startMovement = true;
	}
}
