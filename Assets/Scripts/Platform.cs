using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {
	public enum PlatColor {Red, Blue, Yellow, Violet, Green, Orange};

	public PlatColor color;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.color = getPlatColor(color);
	}

	public Color getPlatColor(PlatColor p) {
		switch (p) {
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
