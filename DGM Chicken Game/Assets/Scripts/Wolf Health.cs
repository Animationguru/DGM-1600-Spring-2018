﻿using System.Collections;
using UnityEngine;

public class WolfHealth : MonoBehaviour {
	public int currentHealth;
	public int maxHealth = 3;
	public Transform spawnPoint;
	public int points;


	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
	}
	
	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth <= 0){
			currentHealth=0;
			print("Wolf is Dead!");
			scoreManager.AddPoints(points);
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;

			currentHealth = maxHealth;

		}
	}
}
