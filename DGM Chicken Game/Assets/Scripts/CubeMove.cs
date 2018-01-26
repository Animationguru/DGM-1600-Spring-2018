using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour {

// public float transX, rotX;
// public float transY, rotY;
// public float transZ, rotZ;



	public Vector3 move;
	public Vector3 rotate;
	// Use this for initialization
	public float moveSpeed, turnSpeed, jumpHeight;
	


	}
	
	// Update is called once per frame
	void Update () {
		var j = Input.GetAxis("Jump") * Time.deltaTime * jumpHeight;
		var y = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

		transform.Translate(0,0,z);
		transform.Translate(0,j,0);
		transform.Rotate(0,y,0);

		// transform.Translate(transX,transY,transZ);
		// transform.Rotate(rotX,rotY,rotZ);
		/*if(Input.GetKey(KeyCode.W)){
			transform.Translate(Vector3.forward * Time.deltaTime * 100);	
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate(Vector3.back * Time.deltaTime * 100);}
		if(Input.GetKey(KeyCode.A)){
			transform.Translate(Vector3.left 
		* Time.deltaTime * 100);}
		if(Input.GetKey(KeyCode.D)){
			transform.Translate(Vector3.right 
		* Time.deltaTime * 100);}*/

		}
	

		// transform.Translate(move * Time.deltaTime);
		// transform.Rotate(rotate * Time.deltaTime);
		
		
	}
