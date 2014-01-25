using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GrowControl : MonoBehaviour {
	
	//How close, measured in units past the edge of the camera's border, before an end branches further?
	public float growThreshold = 1;

	public List<GameObject> extensionPrefabs;

	static public float GROWTHRESHOLD;
	static public List<GameObject> extensions;

	void Start () {
		GROWTHRESHOLD = growThreshold;
		extensions = extensionPrefabs;
	}
	
	// Update is called once per frame
	void Update () {
		//TODO remove debug code
		Camera.main.transform.Translate (Vector3.right * .1f);
	}

	public static GameObject getExtension() {
		return extensions[0];
	}
}
