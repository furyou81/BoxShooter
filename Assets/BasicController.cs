﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Horizontal input = " + Input.GetAxis("Horizontal"));
		Debug.Log("Vertical input = " + Input.GetAxis("Vertical"));		
	}
}
