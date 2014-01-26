using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float speed = 10f;
	public ParticleEmitter sparks;

	void FixedUpdate(){
		sparks.emit = false;
		RaycastHit2D[] above = Physics2D.RaycastAll(transform.position, Vector2.up * 40);
		Platform[] plats = FindObjectsOfType<Platform> ();
		foreach (Platform p in plats) {
			p.solid = true;
		}
		foreach (RaycastHit2D r in above) {
			if (r.collider.gameObject.GetComponent<Platform>() != null)
				r.collider.gameObject.GetComponent<Platform>().solid = false;
		}
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
