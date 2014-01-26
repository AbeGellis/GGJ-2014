using UnityEngine;
using System.Collections;

public class offon : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<BoxCollider2D>().enabled = false;
		GetComponent<BoxCollider2D>().enabled = true;
		GetComponent<CircleCollider2D>().enabled = false;
		GetComponent<CircleCollider2D>().enabled = true;

	}
}
