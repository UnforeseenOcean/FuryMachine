using UnityEngine;
using System.Collections;

public class VignetteManager : MonoBehaviour {
	public GameObject rat;
	public GameObject cat;
	public GameObject bat;
	public GameObject start;
	// Use this for initialization
	void Start () {
		start.SetActive (true);
		rat.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void NextScene(int nextScene)
	{
		switch (nextScene) {
		case 2:
			rat.SetActive (false);
			cat.SetActive (true);
			break;
		}
	}
}
