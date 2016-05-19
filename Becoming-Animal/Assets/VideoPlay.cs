using UnityEngine;
using System.Collections;

public class VideoPlay : MonoBehaviour {

	public MovieTexture mov;

	// Use this for initialization
	void Start () {
		mov.Play ();
		mov.loop = true;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
