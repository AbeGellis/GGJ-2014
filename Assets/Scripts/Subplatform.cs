using UnityEngine;
using System.Collections;

public class Subplatform : Platform {
	//Takes on the color of a "parent" platform
	public Platform parent;

	// Update is called once per frame
	protected override void Update () {
		color = parent.color;
		base.Update();
	}
}
