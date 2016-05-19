﻿using UnityEngine;
using System.Collections;

public class WalkTowards : MonoBehaviour {
	public Transform player;
	public float speed=1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, player.position, step);
	
	}
}
