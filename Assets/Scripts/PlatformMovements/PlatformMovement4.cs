﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement4 : MonoBehaviour {

	private Transform platform;

	// Use this for initialization
	void Start () 
	{
		platform = GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update () 
	{
		platform.transform.position = new Vector2 (Mathf.PingPong(Time.time,5) + 80, platform.transform.position.y);
	}
}