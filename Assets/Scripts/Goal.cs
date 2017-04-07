using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
	
	private GameManager gm;

	void Start() {
		gm = GameManager.instance;
	}
	
	void OnTriggerEnter(Collider other){
		if (other.tag == "Ball" || other.tag == "ExtraBall") {
			Destroy (other.gameObject);
			int scorer = 1;
			bool respawn = false;
			if (this.gameObject.tag == "GoalPost1")
				scorer = 2;
			if (other.tag == "Ball")
				respawn = true;
			gm.AddScore (scorer, respawn);
		}
	}

	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}
}
