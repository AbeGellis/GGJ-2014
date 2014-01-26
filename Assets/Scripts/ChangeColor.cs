using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	public KeyCode red, yellow, blue;
	AudioSource a;

	void Start () {
		renderer.material.color = Color.red;
		gameObject.layer = LayerMask.NameToLayer("Red");
		a = GetComponent<AudioSource>();
	}

	void Update () {
		renderer.material.color = getPlayerColor();
		GetComponent<BoxCollider2D>().enabled = false;
		GetComponent<BoxCollider2D>().enabled = true;
	}

	public Color getPlayerColor(){
		if(Input.GetKeyDown(red)){
			gameObject.layer = LayerMask.NameToLayer("Red");
			a.Play();
			return Color.red;

		}else if(Input.GetKeyDown(yellow)){
			gameObject.layer = LayerMask.NameToLayer("Yellow");
			a.Play();
			return Color.yellow;

		}else if(Input.GetKeyDown(blue)){
			gameObject.layer = LayerMask.NameToLayer("Blue");
			a.Play();
			return Color.blue;

		}else return renderer.material.color;
	}

}
