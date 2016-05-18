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
			if (timer > 0.25f && timer < 0.5f) {
				ratText.enabled = false;
			} else if (timer > 0.5f) {
				timer = 0f;
				flashCount++;
			} else
				ratText.enabled = true;
			if (flashCount > 5)
				state++;
			break;
		case 2:
			ratText.gameObject.SetActive (false);
			if (timer > limitTime) {
				state = 3;
			}
			break;
		case 3:
			SceneManager.LoadSceneAsync (nextScene);
			break;
		}


	
	}
}
