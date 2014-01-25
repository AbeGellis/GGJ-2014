using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float speed = 10f;

	void FixedUpdate(){
	}

	void OnCollisionEnter2D(Collision2D c){
		Debug.Log("hit platform");
		transform.rotation = c.transform.rotation;
		//rigidbody2D.AddForce(transform.right * speed);
		rigidbody2D.velocity = transform.right * speed;
	}

	void OnCollisionStay2D(Collision2D c){
		//rigidbody2D.AddForce(transform.right * speed);
	}

}
