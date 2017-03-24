using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public static GameManager instance;
	private int p1score = 0;
	private int p2score = 0;
	public Text p1ScoreText;
	public Text p2ScoreText;
	public Text gameOverText;

	// Use this for initialization
	void Start () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (this);
		}
		gameOverText.text = "";
		p1ScoreText.text = p1score.ToString ();
		p2ScoreText.text = p2score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddScore ( int player ) {
		if (player == 1) {
			p1score++;
			p1ScoreText.text = p1score.ToString ();
			if (p1score == 10) {
				GameOver (1);
			}
		} else if (player == 2) {
			p2score++;
			p2ScoreText.text = p2score.ToString ();
			if (p2score == 10) {
				GameOver (2);
			}
		}
	}

	private void GameOver( int playerWon ) {
		gameOverText.text = "Player " + playerWon.ToString () + " won!";
	}
}
