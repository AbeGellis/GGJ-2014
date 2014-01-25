using UnityEngine;
using System.Collections;

public class Follower : MonoBehaviour {

	public Transform player;
	public float x;
	public float y;
	
	// Update is called once per frame
	void Update () {
		transform.position = player.position + new Vector3(x, y, 0f);
	}
}
