using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    private int score;
    public Text scoreText;

	void Start () {
        UpdateScore(0);
	}
	
	public void UpdateScore (int newScore) {
        score += newScore;
        scoreText.text = "Score: " + score;
        Debug.Log("score: " + score);
	}
}
