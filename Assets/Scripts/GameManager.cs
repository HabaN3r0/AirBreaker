using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public static GameManager instance;
	public GameObject ball;
	private int p1score = 0;
	private int p2score = 0;
	public Text p1ScoreText;
	public Text p2ScoreText;
	public Text gameOverText;

	// Awake() is used so that it runs before other objects' Start()
	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (this);
		}
		gameOverText.text = "";
		p1ScoreText.text = p1score.ToString ();
		p2ScoreText.text = p2score.ToString ();
	}

	// called by goalposts when ball is scored
	public void AddScore ( int player, bool respawn ) {
//		update score for relevant player
		if (player == 1) {
			p1score++;
			p1ScoreText.text = p1score.ToString ();
		} else if (player == 2) {
			p2score++;
			p2ScoreText.text = p2score.ToString ();
		}
//		check for game over, else respawn ball
		if (p1score == 10)
			StartCoroutine (GameOver (1));
		else if (p2score == 10)
			StartCoroutine (GameOver (2));
		else if (respawn) {
			StartCoroutine (RespawnBall (3 - player));
		}
	}

	// wait for 2s, then instantiate ball on the respective player's side
	IEnumerator RespawnBall ( int side ) {
		yield return new WaitForSecondsRealtime (2);
		if (side == 1)
			Instantiate (ball);
		else if (side == 2)
			Instantiate (ball, new Vector3 (0f, 0.3f, 5f), Quaternion.identity);
	}

	// show which player won, wait 2s, then switch to main menu
	private IEnumerator GameOver( int playerWon ) {
		gameOverText.text = "Player " + playerWon.ToString () + " won!";
		yield return new WaitForSecondsRealtime (2);
        SceneManager.LoadScene("mainmenuscene");
    }
}
