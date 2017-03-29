using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseDrag : MonoBehaviour {
	private Vector3 screenPoint;
	private Vector3 offset;
	void OnMouseDown(){
		
		screenPoint = Camera.main.WorldToScreenPoint (gameObject.transform.position);
		offset =gameObject.transform.position - Camera.main.ScreenToWorldPoint (
			new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}		

	void onMouseDrag(){
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition)+offset;
		transform.position = objPosition;

		}
	}

