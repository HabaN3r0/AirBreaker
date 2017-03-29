using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	void onCollisionEnter(Collider other){
		if (other.gameObject.tag == "Ball")
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
