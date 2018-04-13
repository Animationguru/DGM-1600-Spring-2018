using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public class ScoreManager : MonoBehaviour {

	public static int score;

	public int winScore;
	public Text text;

	public Text winText;

	void Awake(){
		Time.time.Scale = 1;
	}


	// Use this for initialization
	void Start () {
		winText.GetComponent<Text>().enabled = false;
		text = GetComponent<Text>();
			score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(score < 0)
			score = 0;
		text.text =" " + score;

		if(winScore == score ){
			print("Win Score Reached = " + score);
			winText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}

		if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManagment.LoadScene(0);
		}


	}

	public static void AddPoints(int pointsToAdd){
		score += pointsToAdd;
	}	

	public void Reset(){
		score=0;
	}
}
