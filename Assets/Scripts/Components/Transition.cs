using UnityEngine;
using System.Collections;

//Parent class for transitions to help identify them
public class Transition : BasicComponent {
	override public void SetStartColor(Platform.PlatColor c) {
		base.SetStartColor (c);
		EndNode[] en = GetComponentsInChildren<EndNode>();
		foreach (EndNode i in en) {
			i.transitionCanFollow = false;
		}
	}
}
