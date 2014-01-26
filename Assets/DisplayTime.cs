using UnityEngine;
using System.Collections;

public class DisplayTime : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float score = Timer.timer;
		GetComponent<TextMesh>().text = score.ToString() + "\nseconds";
	}
	

}
