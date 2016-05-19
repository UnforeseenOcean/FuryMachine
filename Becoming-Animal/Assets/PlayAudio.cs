using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayAudio : MonoBehaviour {
	public List<AudioClip> clip;
	public Light light;
	private bool colorWeird=false;
	public static bool audioPlaying=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			if (Random.value < 0.005f) {
			colorWeird = true;
				GetComponent<AudioSource> ().PlayOneShot(clip[Random.Range(0,5)]);
				audioPlaying = true;
			}

		if (colorWeird) {
			light.color = new Color (Mathf.Sin (Time.time * 1.5f), Mathf.Cos (Time.time * 2f), Mathf.Sin (Time.time * 1.5f)); 
		}
	
	}


}
