using UnityEngine;
using System.Collections;

public class PlaySoundWhileEmitting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<ParticleEmitter>().emit && GetComponent<AudioSource>().isPlaying == false){
			GetComponent<AudioSource>().Play();
		}else if (!GetComponent<ParticleEmitter>().emit)
			GetComponent<AudioSource>().Stop();
	}
}
