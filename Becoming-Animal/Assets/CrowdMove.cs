using UnityEngine;
using System.Collections;

public class CrowdMove : MonoBehaviour {

	private float changeTimer=0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (changeTimer <0.2f) {
			changeTimer+=Time.deltaTime;	
		}
		if (changeTimer >= 0.15f) {
			transform.localPosition=Camera.main.transform.forward+new Vector3(Random.Range (0f,10f),0f,Random.Range (0f,4f));

				}
	}
}
