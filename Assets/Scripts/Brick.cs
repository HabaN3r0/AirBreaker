using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	private Renderer rend;
	private Collider col;
	public GameObject brickExtraBall;

	void Start () {
		rend = GetComponent<Renderer> ();
		col = GetComponent<Collider> ();
	}
	
	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag != "Ball" && collision.gameObject.tag != "ExtraBall")
			return;				// ignore collisions with anything other than a ball
		rend.enabled = false;	// hide brick
		col.enabled = false;	// disable collider
		float rand = Random.value;
		if (rand < 0.9) {		// 90% of the time: respawn ball
			StartCoroutine (Respawn ());
		} else {				// 10% of the time: instantiate special brick
			Instantiate (brickExtraBall, transform.position, Quaternion.identity);
		}
	}

	IEnumerator Respawn () {	// wait 8s, then unhide brick
		yield return new WaitForSecondsRealtime (8);
		rend.enabled = true;
		col.enabled = true;
	}
}
