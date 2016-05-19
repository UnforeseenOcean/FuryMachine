using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VR;
using System.Collections;

public class PlayerIF : MonoBehaviour {
	private Ray ray;
	public Transform quadTransform;
	public Text startText;
	private bool wasLooking=false;
	private float lookTimer=5f;
	private bool startGame=false;
	// Use this for initialization
	void Start () {
	
	}
	void Update()
	{
		Ray ray = new Ray (transform.position, transform.forward);
		// this var will tell us where and what it hit
		RaycastHit rayHitInfo = new RaycastHit ();

		//Debug.DrawRay (ray.origin, ray.direction * 1000f, Color.yellow);

		// actually shooting the raycast now
		if (Physics.Raycast (ray, out rayHitInfo, 1000f)) {

			Debug.Log (rayHitInfo.transform.gameObject.name);
			// is the raycast hitting the thing we put this script on?
			GetComponent<WalkTowards>().player=rayHitInfo.transform;
			//	Debug.Log ("LOOKING");
			OnLooking ();
			if (wasLooking == false) {
				wasLooking = true;
				OnStartLook ();
			}
		} else {
			OnNotLooking ();
			if (wasLooking == true) {
				wasLooking = false;
				OnEndLook ();
			}
		}
	}

// code that will happen when I start looking at something
void OnStartLook () {

}

// code that will happen the instant when I stopped looking at something
void OnEndLook () {

}

// code that will happen CONSTANTLY as long as we're looking at it
void OnLooking () {

}
void OnNotLooking () {
}
}
