using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mallet : MonoBehaviour {
	public float Malletspeed = 10;
	private Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		float horiz = Input.GetAxis ("Horizontal");
		float vert = Input.GetAxis ("Vertical");
		rigidbody.AddForce( new Vector3 (horiz, 0.0f, vert) * Malletspeed );
	}
//	void onCollisionEnter (Collider col){
//		if(col.gameObject.tag=="wall"){
//		}
//		if(col.gameObject.tag=="GoalPost1"||col.gameObject.tag=="GoalPost2"){
//		}
}
