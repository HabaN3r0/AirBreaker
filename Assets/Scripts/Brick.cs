using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	private Renderer rend;
	private Collider col;
	public GameObject brickExtraBall;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		col = GetComponent<Collider> ();
	}
	
	void OnCollisionEnter () {
		rend.enabled = false;
		col.enabled = false;
		float rand = Random.value;
		if (rand < 0.9) {
			StartCoroutine (Respawn ());
		} else {
			Instantiate (brickExtraBall, transform.position, Quaternion.identity);
		}
	}

	IEnumerator Respawn () {
		yield return new WaitForSecondsRealtime (8);
		rend.enabled = true;
		col.enabled = true;
	}
}
