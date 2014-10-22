using UnityEngine;
using System.Collections;

public class ScoreUp : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		GameControl.score = GameControl.score + 1;
		Debug.Log (GameControl.score);
	}	
}
