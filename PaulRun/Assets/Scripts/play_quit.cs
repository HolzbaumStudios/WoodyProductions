using UnityEngine;
using System.Collections;

public class play_quit : MonoBehaviour {
	

	// Use this for initialization
	void Start () {

	}

	public void exitGame () {
		Application.Quit ();
	}


	public void changeScene (string PlayGame){
		StartCoroutine (StartSound (PlayGame));
	}

	IEnumerator StartSound (string PlayGame) {
		audio.Play();
		yield return new WaitForSeconds(audio.clip.length);

		Application.LoadLevel (PlayGame);
	}


}
