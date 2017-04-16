using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MalletController : MonoBehaviour {

	//Public Variables
	public GameObject player1;
	public GameObject player2;
	//A modifier which affects the rackets speed
//	public float speed;
	//Fraction defined by user that will limit the touch area
	//public int id;
	//Private Variables
	private Vector3 player1Pos;
	private Vector3 player2Pos;
	private bool touched = false;
	// Use this for initialization
	void Start () 
	{
		//Cache called function variables
		player1Pos = player1.transform.position;
		player2Pos = player2.transform.position;
	}

	// Update is called once per frame
	void Update () 
	{

		//If a touch is detected
		if (Input.touchCount >= 0)
		{
			//For each touch
			foreach (Touch touch in Input.touches)
			{

				//Cache touch position
				Ray ray = Camera.main.ScreenPointToRay(touch.position);
//				Vector3 worldPos = Camera.main.ScreenToWorldPoint (touch.position);
//				Vector3 localtouchCache = Camera.main.ScreenToWorldPoint(touch.position);
				RaycastHit hit;
				if (Physics.Raycast (ray, out hit, 100)) {
					Debug.DrawRay (ray.origin, ray.direction * 1000f, Color.red);
						//Debug.Log (hit.collider.gameObject);
					if (hit.collider.gameObject == player1) {
						if (hit.point.z <= -2.3f&&hit.point.z >= -9.7f) {
							player1.transform.position = new Vector3 (hit.point.x, 0f, hit.point.z);
						}
					} else if (hit.collider.gameObject == player2) 
					{
						if (hit.point.z >= 2.3f&&hit.point.z <= 9.7f) {
							player2.transform.position = new Vector3 (hit.point.x, 0f, hit.point.z);
						}
					}
				}

			}
			touched = true;
		}
	}
}
