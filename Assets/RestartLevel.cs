using UnityEngine;
using System.Collections;

public class RestartLevel : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D c){
		Application.LoadLevel(Application.loadedLevel);
	}
}
