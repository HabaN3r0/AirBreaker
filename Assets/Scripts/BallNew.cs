using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallNew : MonoBehaviour {

	private Rigidbody rb;
	private bool ballInPlay;

	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> ();
		ballInPlay = false;
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Mallet") {
			Vector3 otherPos = other.gameObject.transform.position;
			Vector3 thisPos = this.transform.position;
			if (!ballInPlay) {
				rb.AddForce (new Vector3 (thisPos.x - otherPos.x, 0.0f, thisPos.z - otherPos.z) * 500);
				ballInPlay = true;
			} else {
				rb.AddForce (new Vector3 (thisPos.x - otherPos.x, 0.0f, thisPos.z - otherPos.z) * 200);
			}
		}
		ballInPlay = true;
		if (rb.velocity.magnitude > 20)
			rb.velocity = rb.velocity.normalized * 20;
	}

	void FixedUpdate () {
		float horiz = Input.GetAxis ("Horizontal");
		float vert = Input.GetAxis ("Vertical");
		rb.AddForce( new Vector3 (horiz, 0.0f, vert) * 10 );
	}
}