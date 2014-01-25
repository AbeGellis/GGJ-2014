using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform tofollow;
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp(transform.position, new Vector3(tofollow.transform.position.x, transform.position.y, transform.position.z), 1f);
	}

	public void Shake(float x, float y, float t){
		StartCoroutine(ScreenShake(x, y, t));
	}

	IEnumerator ScreenShake (float x, float y, float t){

		while(t > 0f){
			t -= Time.deltaTime;
			Camera.main.transform.position += t *
				new Vector3(Mathf.Sin (Time.time*100f) * x, 
				            Mathf.Sin (Time.time*100f) * y, 0f); 
			yield return 0;
		}
	}

}
