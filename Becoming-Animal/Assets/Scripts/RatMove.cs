using UnityEngine;
using System.Collections;
using UnityEngine.VR;
public class RatMove : MonoBehaviour {

	private CharacterController cont;
	public float speed=10f;
	private Vector3 oldPos;
    public VRNode camNode;
    public Transform camRot;
	// Use this for initialization
	void Start () {
		oldPos = transform.position;
		InvokeRepeating ("CheckMove", 1f, 0.1f);
		cont = transform.parent.gameObject.GetComponent<CharacterController> ();
        VRSettings.renderScale = 1.5f;
    }
	
	// Update is called once per frame
	void Update () {
        
		cont.SimpleMove (camRot.transform.forward * speed);
        //transform.eulerAngles = camRot.transform.eulerAngles;
	}

	void CheckMove()
	{
        
		Vector3 currentPos = transform.position;
		if (Vector3.Distance (currentPos, oldPos) < 0.1f) {
		//	Debug.Log ("nice");
            speed = 10f;
			transform.eulerAngles = new Vector3 (0f, transform.eulerAngles.y+180f, 0f);
		}
        else if(speed <20f)
        {
            speed+=0.1f; 
        } 
		oldPos = currentPos;
	}
}
