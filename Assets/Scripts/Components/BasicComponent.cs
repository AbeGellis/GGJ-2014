using UnityEngine;
using System.Collections;

//A simple monocolor 
public class BasicComponent : PlatComponent {

	override public void SetStartColor(Platform.PlatColor c) {
		startColor = c;
		Platform[] pl = GetComponentsInChildren<Platform>();
		EndNode[] en = GetComponentsInChildren<EndNode>();
		foreach (Platform i in pl) {
			i.color = c;
		}
		foreach (EndNode i in en) {
			i.nextColor = c;
		}
	}
}
