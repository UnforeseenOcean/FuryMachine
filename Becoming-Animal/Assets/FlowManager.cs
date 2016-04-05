using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class FlowManager : MonoBehaviour {

	private int state=0;
	private float timer=0f;
	public Text ratText;
	private int flashCount=0;
	public GameObject blackScreen;
	// Use this for initialization
	void Start () {
	
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
			blackScreen.SetActive (false);
			break;
		}
	
	}
}
