using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GrowControl : MonoBehaviour {
	
	//How close, measured in units past the edge of the camera's border, before an end branches further?
	public float growThreshold = 1f;
	//How far past the edge before destroying the component
	public float killThreshold = 1f;

	//Don't grow higher than the top (from the top of the screen) or lower than the bottom (from the bottom of the screen)
	public float top = .2f;
	public float bottom = .2f;

	public List<GameObject> extensionPrefabs;

	public GameObject rampDown;
	public GameObject rampUp;

	static public float GROWTHRESHOLD;
	static public float KILLTHRESHOLD;
	static public float TOP;
	static public float BOTTOM;
	static public GameObject RAMPDOWN;	//Special notice to drive the player back into the view
	static public GameObject RAMPUP;
	static public List<GameObject> extensions;
	static public List<GameObject> extensionsNT;	//Non-transitions only

	void Start () {
		GROWTHRESHOLD = growThreshold;

		RAMPDOWN = rampDown;
		RAMPUP = rampUp;
		//TOP = -Camera.main.ViewportToWorldPoint(Vector3.down).y - top;
		//BOTTOM = -Camera.main.ViewportToWorldPoint(Vector3.zero).y + bottom;
		extensions = extensionPrefabs;
		extensionsNT = new List<GameObject> ();
		foreach (GameObject o in extensions) {
			if (o.GetComponent<Transition>() == null)
				extensionsNT.Add(o);
		}
	}
	
	// Update is called once per frame
	void Update () {
		//TODO remove debug code
		Camera.main.transform.Translate (Vector3.right * .1f);
		TOP = Camera.main.orthographicSize - top;
		BOTTOM = -Camera.main.orthographicSize + bottom;
	}

	public static GameObject getExtension(bool transitionCanFollow = true) {
		List<GameObject> options = transitionCanFollow ? extensions : extensionsNT;

		int index = Random.Range (0, options.Count);
		return options[index];
	}

	public static GameObject getExtDown() {
		return RAMPDOWN;
	}

	public static GameObject getExtUp() {
		return RAMPUP;
	}
}
