using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform tofollow;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(tofollow.position.x, transform.position.y, transform.position.z);
	}
}
