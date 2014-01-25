using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {
	public enum PlatColor {Red, Blue, Yellow, Violet, Green, Orange};

	public PlatColor color;

	void Start () {

	}
	
	// Update is called once per frame
	protected virtual void Update () {
		renderer.material.color = getPlatColor(color);
	}

	public Color getPlatColor(PlatColor p) {
		switch (p) {
		case PlatColor.Red:
			gameObject.layer = LayerMask.NameToLayer("Red");
			return Color.red;
		case PlatColor.Blue:
			gameObject.layer = LayerMask.NameToLayer("Blue");
			return Color.blue;
		case PlatColor.Green:
			gameObject.layer = LayerMask.NameToLayer("Green");
			return Color.green;
		case PlatColor.Orange:
			gameObject.layer = LayerMask.NameToLayer("Orange");
			return Color.Lerp(Color.red, Color.yellow, .5f);
		case PlatColor.Violet:
			gameObject.layer = LayerMask.NameToLayer("Violet");
			return Color.Lerp(Color.red, Color.blue, .5f);
		case PlatColor.Yellow:
			gameObject.layer = LayerMask.NameToLayer("Yellow");
			return Color.yellow;
		}
		return Color.white;
	}
}
