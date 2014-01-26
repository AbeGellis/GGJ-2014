using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	public KeyCode red, yellow, blue;
	AudioSource a;

	void Start () {
		renderer.material.color = ColorManager.red;
		ColorManager.red.a = 1f;
		ColorManager.yellow.a = .15f;
		ColorManager.blue.a = .15f;
		ColorManager.green.a = .15f;
		ColorManager.orange.a = 1f;
		ColorManager.violet.a = 1f;
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
			ColorManager.red.a = 1f;
			ColorManager.yellow.a = .15f;
			ColorManager.blue.a = .15f;
			ColorManager.green.a = .15f;
			ColorManager.orange.a = 1f;
			ColorManager.violet.a = 1f;

			return ColorManager.red;

		}else if(Input.GetKeyDown(yellow)){
			gameObject.layer = LayerMask.NameToLayer("Yellow");
			a.Play();
			ColorManager.red.a = .15f;
			ColorManager.yellow.a = 1f;
			ColorManager.blue.a = .15f;
			ColorManager.green.a = 1f;
			ColorManager.orange.a = 1f;
			ColorManager.violet.a = .15f;
			return ColorManager.yellow;

		}else if(Input.GetKeyDown(blue)){
			gameObject.layer = LayerMask.NameToLayer("Blue");
			a.Play();
			ColorManager.red.a = .15f;
			ColorManager.yellow.a = .15f;
			ColorManager.blue.a = 1f;
			ColorManager.green.a = 1f;
			ColorManager.orange.a = .15f;
			ColorManager.violet.a = 1f;
			return ColorManager.blue;

		}else return renderer.material.color;
	}

}
