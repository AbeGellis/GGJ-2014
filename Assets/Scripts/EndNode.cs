using UnityEngine;
using System.Collections;

public class EndNode : MonoBehaviour {


	bool grown = false;

	void Start () {
	}

	void Update () {
		//Grow if within grow threshold
		if (!grown) {
			float camLeadingEdge = Camera.main.ViewportToWorldPoint (Vector3.right).x;
			if (transform.position.x < camLeadingEdge + GrowControl.GROWTHRESHOLD) {
				grown = true;
				Grow ();
			}
		} else {	//Destroy platform if past view
			float camTrailingEdge = Camera.main.ViewportToWorldPoint (Vector3.zero).x;
			if (transform.position.x < camTrailingEdge)
				Destroy(transform.parent.gameObject);
		}
	}

	void Grow() {
		GameObject ext = Instantiate(GrowControl.getExtension ()) as GameObject;
		ext.transform.position = transform.position;
	}
}
