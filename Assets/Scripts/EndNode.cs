using UnityEngine;
using System.Collections;

public class EndNode : MonoBehaviour {


	public bool grown = false;
	public Platform.PlatColor nextColor;
	public bool transitionCanFollow = true;

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
			if (transform.position.x < (camTrailingEdge - GrowControl.KILLTHRESHOLD))
				Destroy(transform.parent.gameObject);
		}
	}

	void Grow() {
		if (!Physics2D.Raycast(transform.position + Vector3.right/5f, Vector2.zero)) {
			if (transform.position.y > GrowControl.BOTTOM) {
				if (transform.position.y < GrowControl.TOP) {
					GameObject ext = Instantiate(GrowControl.getExtension(transitionCanFollow)) as GameObject;
					ext.transform.position = transform.position;
					ext.GetComponent<PlatComponent>().SetStartColor(nextColor);
				} else {
					GameObject ext = Instantiate(GrowControl.getExtDown()) as GameObject;
					ext.transform.position = transform.position;
					ext.GetComponent<PlatComponent>().SetStartColor(nextColor);
				}
			} else {
				GameObject ext = Instantiate(GrowControl.getExtUp()) as GameObject;
				ext.transform.position = transform.position;
				ext.GetComponent<PlatComponent>().SetStartColor(nextColor);
			}
		}
	}
}
