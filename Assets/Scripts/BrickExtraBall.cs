﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickExtraBall : MonoBehaviour {

	public GameObject ball;
	
	void OnCollisionEnter () {
		Destroy (gameObject);
		GameObject extraBall = Instantiate (ball, transform.position, Quaternion.identity) as GameObject;
		extraBall.GetComponent<Rigidbody>().AddForce( 
			new Vector3((Random.value-0.5f)*200, 0, -200) );
	}
}
