using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float speed = 10f;
	public ParticleEmitter sparks;
	public BoxCollider2D box;
	public CircleCollider2D circle1;
	public CircleCollider2D circle2;

	float prevX = 0f;

	void FixedUpdate(){
		sparks.emit = false;
		rigidbody2D.AddForce(new Vector2(20f, 0f));
	}

	void Update(){
		box.gameObject.layer = gameObject.layer;
		circle1.gameObject.layer = gameObject.layer;
		circle2.gameObject.layer = gameObject.layer;
		RaycastHit2D[] above1 = Physics2D.RaycastAll(box.transform.position+Vector3.up*.2f, transform.up);
		RaycastHit2D[] above2 = Physics2D.RaycastAll(circle1.transform.position+transform.up*.25f, transform.up);
		RaycastHit2D[] above3 = Physics2D.RaycastAll(circle2.transform.position+transform.up*.2f, transform.up);
		Debug.DrawRay(box.transform.position+transform.up*.2f, transform.up*40);
		//Debug.DrawRay(circle1.transform.position+transform.up*.25f, transform.up*40);
		//Debug.DrawRay(circle2.transform.position+transform.up*.2f, transform.up*40);
		Platform[] plats = FindObjectsOfType<Platform> ();
		foreach (Platform p in plats) {
			p.solid = true;
		}
		foreach (RaycastHit2D r in above1) {
			if (r.collider.gameObject.GetComponent<Platform>() != null)
				r.collider.gameObject.GetComponent<Platform>().solid = false;
		}
		/*foreach (RaycastHit2D r in above2) {
			if (r.collider.gameObject.GetComponent<Platform>() != null)
				r.collider.gameObject.GetComponent<Platform>().solid = false;
		}*/
		/*foreach (RaycastHit2D r in above3) {
			if (r.collider.gameObject.GetComponent<Platform>() != null)
				r.collider.gameObject.GetComponent<Platform>().solid = false;
		}*/

		if (Mathf.Abs (prevX - transform.position.x) < .01f) {
			transform.Translate(.1f, .02f, 0f);
			rigidbody2D.AddForce (Vector2.up * 2f);
		}
		prevX = transform.position.x;
		//transform.Translate (.01f, 0f, 0f);
		//rigidbody2D.AddForce (Vector2.up);
	}

	void OnCollisionEnter2D(Collision2D c){
		Camera.main.GetComponent<CameraFollow>().Shake(.1f,.1f,.2f);
		transform.rotation = c.transform.rotation;
		rigidbody2D.velocity = Vector2.right * speed;
		sparks.emit = true;		
	}

	void OnCollisionStay2D(Collision2D c){
		Camera.main.GetComponent<CameraFollow>().Shake(.1f,.1f,.2f);
		transform.rotation = c.transform.rotation;
		rigidbody2D.velocity = Vector2.right * speed;
		sparks.emit = true;		

	}

}
