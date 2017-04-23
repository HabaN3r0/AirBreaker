using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MalletController : MonoBehaviour {

	//Public Variables
	public GameObject player1;
	public GameObject player2;
		
	void Update () 
	{
		//If a touch is detected
		if (Input.touchCount >= 0)
		{
			//For each touch
			foreach (Touch touch in Input.touches)
			{
				//detect touch position
				Ray ray = Camera.main.ScreenPointToRay(touch.position);
				RaycastHit hit;
				if (Physics.Raycast (ray, out hit, 100)) {
					Debug.DrawRay (ray.origin, ray.direction * 1000f, Color.red);

					// if touch is near player's mallet and within his half of the game board, move the mallet to the touch position
					//if mallet 1 is being touched
					if (hit.collider.gameObject == player1) {
						// limiting the activity range of the mallet as well as ensure the right mallet changes position
						if (hit.point.z <= -2.2f&&hit.point.z >= -9.0f && hit.point.x >= -5.6f && hit.point.x <= 5.6f) {
							player1.transform.position = new Vector3 (hit.point.x, 0f, hit.point.z);
						}
						//if mallet 2 is being touched
					} else if (hit.collider.gameObject == player2) {
						// limiting the activity range of the mallet as well as ensure the right mallet changes position
						if (hit.point.z >= 2.2f&&hit.point.z <= 9.0f && hit.point.x >= -5.6f && hit.point.x <= 5.6f) {
							player2.transform.position = new Vector3 (hit.point.x, 0f, hit.point.z);
						}
					}
				}

			}
		}
	}
}
