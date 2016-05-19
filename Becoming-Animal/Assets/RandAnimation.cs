using UnityEngine;
using System.Collections;

public class RandAnimation : MonoBehaviour {

	public GameObject cam;
	private Ray ray;
	//public Transform quadTransform;
	//public Text startText;
	private bool wasLooking=false;
	private bool canChange=false;
	private float changeTimer=0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = new Ray(cam.transform.position,cam.transform.forward );
		// this var will tell us where and what it hit
		RaycastHit rayHitInfo = new RaycastHit();

		Debug.DrawRay( ray.origin, ray.direction * 1000f, Color.yellow );

		// actually shooting the raycast now
		if ( Physics.Raycast( ray, out rayHitInfo, 1000f ) 
			&& rayHitInfo.transform == transform ) {
			// is the raycast hitting the thing we put this script on?
			//Debug.Log("LOOKING");
			OnLooking();
			if ( wasLooking == false ) {
				wasLooking = true;
				OnStartLook();
			}
		} else {
			OnNotLooking();
			if ( wasLooking == true ) {
				wasLooking = false;
				OnEndLook();
			}
		}

		if (canChange) {
			GetComponent<Animator> ().SetBool ("Change", true);
	
		}
		else
			GetComponent<Animator> ().SetBool ("Change",false);

	}

	// code that will happen when I start looking at something
	void OnStartLook () {

	}

	// code that will happen the instant when I stopped looking at something
	void OnEndLook () {
		//Debug.Log ("STOPPED LOOKING");
		if (!canChange)
			canChange = true;
		else
			canChange = false;

	}

	// code that will happen CONSTANTLY as long as we're looking at it
	void OnLooking () {

	}
	void OnNotLooking () {
		
	}
}
