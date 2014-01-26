using UnityEngine;
using System.Collections;

public class PlaySparkSound : MonoBehaviour {

	public AudioClip[] sparks = new AudioClip[5];

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.parent.GetComponent<ParticleEmitter>().emit && !GetComponent<AudioSource>().isPlaying){
			int i = Random.Range(0,5);
			GetComponent<AudioSource>().clip = sparks[i];
			GetComponent<AudioSource>().Play();

		}

	}
}
