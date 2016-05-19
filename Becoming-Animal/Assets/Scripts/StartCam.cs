using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.VR;
using UnityEngine.SceneManagement;
public class StartCam : MonoBehaviour {

    private Ray ray;
	public Transform quadTransform;
	public Text startText;
	private bool wasLooking=false;
	private float lookTimer=5f;
	private bool startGame=false;
	void Start () {
		//InputTracking.Recenter ();
	}
	
	// Update is called once per frame
	void Update () {

		if (!startGame)
			startText.text = "LOOK HERE FOR \n" + Mathf.CeilToInt (lookTimer).ToString () + " SECONDS \n TO \n START GAME";
		else {
			StartCoroutine ("StartGame");
		}

		Ray ray = new Ray(transform.position,transform.forward );
		// this var will tell us where and what it hit
		RaycastHit rayHitInfo = new RaycastHit();

		Debug.DrawRay( ray.origin, ray.direction * 1000f, Color.yellow );

		// actually shooting the raycast now
		if ( Physics.Raycast( ray, out rayHitInfo, 1000f ) 
			&& rayHitInfo.transform == quadTransform ) {
			// is the raycast hitting the thing we put this script on?
			Debug.Log("LOOKING");
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

	}

	// code that will happen when I start looking at something
	void OnStartLook () {

	}

	// code that will happen the instant when I stopped looking at something
	void OnEndLook () {

	}

	// code that will happen CONSTANTLY as long as we're looking at it
	void OnLooking () {
		startText.color = Color.green;

		if (lookTimer >= -0.1f)
			lookTimer -= Time.deltaTime;
		else {
			startGame = true;
		}
		
	}
	void OnNotLooking () {
		lookTimer = 5f;
		startText.color = Color.red;
	}

	IEnumerator StartGame()
	{
		
		startText.text = "STARTING GAME";
		SceneManager.LoadSceneAsync (1);
		yield return null;
	}

}
