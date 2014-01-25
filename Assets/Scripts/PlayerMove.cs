using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float speed = 10f;

	void FixedUpdate(){
	}

	void OnCollisionEnter2D(Collision2D c){
		Camera.main.GetComponent<CameraFollow>().Shake(.1f,.1f,.2f);
		Debug.Log("hit platform");
		transform.rotation = c.transform.rotation;
		rigidbody2D.velocity = transform.right * speed;
	}

	void OnCollisionStay2D(Collision2D c){
		rigidbody2D.velocity = transform.right * speed;
	}

}
