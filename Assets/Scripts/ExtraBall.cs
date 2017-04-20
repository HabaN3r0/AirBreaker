using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBall : MonoBehaviour {

	public float speed = 10;
	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Mallet") {
			Vector3 otherPos = other.gameObject.transform.position;
			Vector3 thisPos = this.transform.position;
			rb.AddForce (new Vector3 (thisPos.x - otherPos.x, 0.0f, thisPos.z - otherPos.z) * 200);
		}
		if (rb.velocity.magnitude > 15)
			rb.velocity = rb.velocity.normalized * 15;
	}

	void FixedUpdate () {
		float horiz = Input.GetAxis ("Horizontal");
		float vert = Input.GetAxis ("Vertical");
		rb.AddForce( new Vector3 (horiz, 0.0f, vert) * speed );
	}

}
