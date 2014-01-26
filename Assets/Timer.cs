using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public static float timer;
	
	void Update(){
		timer += Time.deltaTime;
	}
}
