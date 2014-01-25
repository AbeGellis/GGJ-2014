using UnityEngine;
using System.Collections;

//Transition from one primary color to another.  No branch.
//If it starts on a transition color, it stays on the transition color, but changes to a primary color after.
public class BasicTransition : Transition {

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
			p = c;
			switch (c) {
			case Platform.PlatColor.Violet:
				n = choice ? Platform.PlatColor.Blue : Platform.PlatColor.Red;
				break;
			case Platform.PlatColor.Orange:
				n = choice ? Platform.PlatColor.Yellow : Platform.PlatColor.Red;
				break;
			case Platform.PlatColor.Green:
				n = choice ? Platform.PlatColor.Blue : Platform.PlatColor.Yellow;
				break;
			default:
				print ("If you are seeing this something went wrong");
				n = Platform.PlatColor.Orange;
				break;
			}
			break;
		}
		Platform[] pl = GetComponentsInChildren<Platform>();
		EndNode[] en = GetComponentsInChildren<EndNode>();
		foreach (Platform i in pl) {
			i.color = p;
		}
		foreach (EndNode i in en) {
			i.nextColor = n;
		}
	}
}
