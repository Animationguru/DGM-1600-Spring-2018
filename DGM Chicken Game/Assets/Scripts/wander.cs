using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wander : MonoBehaviour {
	public float moveSpeed;
	public Transform target;

	//public int damage;

	//public GameObject pcHealth;
	
	public void Wandering(){
	
	//makes the animal wander
	transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
	int randomnum = Random.Range(0,360);
	Vector3 fwd = transform.TransformDirection(Vector3.forward);
	RaycastHit hit;


	Debug.DrawRay(transform.position,fwd*3, Color.red);

		if(Physics.Raycast(transform.position,fwd,out hit,3)){
		
			if(hit.collider.tag == "wall"){
			transform.Rotate(0,randomnum,0);
			}
		}
	}	
	void OnTriggerStay(Collider other){
		if(other.gameObject.tag == "Player"){
			if(target == null){target = other.gameObject.GetComponent<Transform>();}
			Follow();
		}
	}
	void Follow(){
		transform.LookAt(target);
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		
	}
}