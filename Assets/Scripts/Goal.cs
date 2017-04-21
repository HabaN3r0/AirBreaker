using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
	
	private GameManager gm;
	private Collider col;

	void Start() {
		col = GetComponent<BoxCollider>();
		gm = GameManager.instance;
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Mallet") {		// collide normally with mallet
			col.isTrigger = false;
		}
		if (other.tag == "Ball" || other.tag == "ExtraBall") {
			col.isTrigger = true;
			Destroy (other.gameObject);		// destroy ball

			// determine which player scored and whether to respawn ball
			int scorer = 1;
			bool respawn = false;
			if (this.gameObject.tag == "GoalPost1")
				scorer = 2;
			if (other.tag == "Ball")
				respawn = true;
			gm.AddScore (scorer, respawn);	// let gm handle scoring and respawning
		}
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "Mallet") {		// reset trigger to true after mallet leaves
			col.isTrigger = true;
		}
	}

}
