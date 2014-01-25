using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float speed = 10f;
	public ParticleEmitter sparks;

	void FixedUpdate(){
		sparks.emit = false;
	}

	void OnCollisionEnter2D(Collision2D c){
		Camera.main.GetComponent<CameraFollow>().Shake(.1f,.1f,.2f);
		transform.rotation = c.transform.rotation;
		rigidbody2D.velocity = transform.right * speed;
		sparks.emit = true;		
	}

	void OnCollisionStay2D(Collision2D c){
		Camera.main.GetComponent<CameraFollow>().Shake(.1f,.1f,.2f);
		rigidbody2D.velocity = transform.right * speed;
		sparks.emit = true;

	}

}
