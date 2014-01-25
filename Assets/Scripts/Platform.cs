using UnityEngine;
using System.Collections;

public enum PlatColor {Red, Blue, Yellow, Violet, Green, Orange};

public class Platform : MonoBehaviour {

	public PlatColor color;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.color = getPlatColor();
	}

	public Color getPlatColor() {
		switch (color) {
		case PlatColor.Red:
			return Color.red;
		case PlatColor.Blue:
			return Color.blue;
		case PlatColor.Green:
			return Color.green;
		case PlatColor.Orange:
			return Color.Lerp(Color.red, Color.yellow, .5f);
		case PlatColor.Violet:
			return Color.Lerp(Color.red, Color.blue, .5f);
		case PlatColor.Yellow:
			return Color.yellow;
		}
		return Color.white;
	}
}
