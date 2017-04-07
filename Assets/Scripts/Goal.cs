using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
	
	void OnTriggerEnter(Collider other){
		if (other.tag == "Ball")
			Destroy (other.gameObject);
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
