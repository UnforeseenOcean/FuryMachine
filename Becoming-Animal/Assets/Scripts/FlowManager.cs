using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.VR;
using UnityEngine.SceneManagement;
public class FlowManager : MonoBehaviour {

	private int state=0;
	private float timer=0f;
	public Text ratText;
	public float limitTime=30f;
	private int flashCount=0;
	public int nextScene=2;


	// Use this for initialization
	void Start () {
		VRSettings.renderScale = 1.5f;
		state = 1;
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		switch (state) {

		case 1:
			if (timer < 3f)
				ratText.enabled = true;
			else {
				ratText.enabled = false;
				state = 2;
			}
			break;
		case 2:
			ratText.gameObject.SetActive (false);
			if (timer > limitTime) {
				state = 3;
			}
			break;
		case 3:
			SceneManager.LoadScene (nextScene);
			break;
		}


	
	}
}
