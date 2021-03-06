﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float moveSpeed, turnSpeed, jumpHeight;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		var j = Input.GetAxis("Jump") * Time.deltaTime * jumpHeight;
		var y = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

		transform.Translate(0,0,z);
		transform.Translate(0,j,0);
		transform.Rotate(0,y,0);
	}
}
