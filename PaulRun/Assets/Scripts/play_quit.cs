using UnityEngine;
using System.Collections;

public class play_quit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void changeScene (string PlayGame){
		Application.LoadLevel (PlayGame);
	}

	public void exitGame () {
		Application.Quit ();
	}
}
