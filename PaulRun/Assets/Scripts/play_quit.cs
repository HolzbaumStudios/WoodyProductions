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
		StartCoroutine (StartSound ());
		Application.LoadLevel (PlayGame);
	}

	IEnumerator StartSound () {
		audio.Play();
		while (audio.isPlaying) {
			yield return new WaitForSeconds(audio.clip.length);
		}
	}


}
