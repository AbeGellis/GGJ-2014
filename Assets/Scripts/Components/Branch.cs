using UnityEngine;
using System.Collections;

public class Branch : Transition {

	public GameObject root;
	public GameObject path1;
	public GameObject path2;

	public GameObject end1;
	public GameObject end2;

	override public void SetStartColor(Platform.PlatColor c) {
		base.SetStartColor (c);
		startColor = c;
		
		Platform.PlatColor p, n;
		bool choice = (Random.Range(0, 2) == 1);
		switch (startColor) {
		case Platform.PlatColor.Blue:
			p = choice ? Platform.PlatColor.Violet : Platform.PlatColor.Green;
			n = choice ? Platform.PlatColor.Red : Platform.PlatColor.Yellow;
			break;
		case Platform.PlatColor.Red:
			p = choice ? Platform.PlatColor.Violet : Platform.PlatColor.Orange;
			n = choice ? Platform.PlatColor.Blue : Platform.PlatColor.Yellow;
			break;
		case Platform.PlatColor.Yellow:
			p = choice ? Platform.PlatColor.Orange : Platform.PlatColor.Green;
			n = choice ? Platform.PlatColor.Red : Platform.PlatColor.Blue;
			break;
		default:
			p = c;	//This should not happen and I don't care what happens if it does
			n = c;
			break;
		}

		choice = Random.Range (0, 2) == 1;
		root.GetComponent<Platform>().color = p;
		path1.GetComponent<Platform>().color = choice ? n : c;
		path2.GetComponent<Platform>().color = choice ? c : n;
		end1.GetComponent<EndNode>().nextColor = choice ? n : c;
		end2.GetComponent<EndNode>().nextColor = choice ? c : n;
	}
}
