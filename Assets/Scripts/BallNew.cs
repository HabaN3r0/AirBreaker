using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallNew : MonoBehaviour {
	public float ballInitialVelocity=600f;

	private Rigidbody rb;
	private bool ballInPlay;

	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> ();
		ballInPlay = false;
	}
	
	// Update is called once per frame
//	void Update () {
//		if(Input.GetButtonDown("Fire1")&& ballInPlay==false){
//			transform.parent = null;
//			ballInPlay = true;
//			rb.isKinematic = false;
//			rb.AddForce(new Vector3(0,0,ballInitialVelocity));
//		}
//	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Mallet") {
			Vector3 otherPos = other.gameObject.transform.position;
			Vector3 thisPos = this.transform.position;
			if (ballInPlay) {
				rb.AddForce (new Vector3 (thisPos.x - otherPos.x, 0.0f, thisPos.z - otherPos.z) * 300);
				ballInPlay = true;
			} else {
				rb.AddForce (new Vector3 (thisPos.x - otherPos.x, 0.0f, thisPos.z - otherPos.z) * 200);
			}
		}
	}

	void FixedUpdate () {
		float horiz = Input.GetAxis ("Horizontal");
		float vert = Input.GetAxis ("Vertical");
		rb.AddForce( new Vector3 (horiz, 0.0f, vert) * 10 );
	}
}