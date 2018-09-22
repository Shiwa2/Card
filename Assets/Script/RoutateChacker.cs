using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoutateChacker : MonoBehaviour {
	
//	public Transform pos;
//	public Vector3[] endPositions;
	public GameObject black_boxRight;
	public GameObject black_boxLift;

//
//	void OnMouseDown(){
//		for (int i = 0; i < InputManager.instance.objects.Count; i++) {
//			//InputManager.instance.objects[i].transform.position = Vector3.Lerp (InputManager.instance.objects[i].transform.position,transform.position, 1.2f);
//			//InputManager.instance.objects[i].transform.position = Vector3.Lerp (InputManager.instance.objects[i].transform.position, endPositions[].transform.position, 1.2f);
//
//			//print (InputManager.instance.objects[i].name);
//		}
//	}

	void OnTriggerEnter2D (Collider2D col){
		if (col.gameObject.CompareTag ("Wood")) {
			if (gameObject.name == "black_boxRight"){
			col.gameObject.transform.Rotate (0f, 0f, 89.853f);
			}
			if (gameObject.name == "black_boxLift"){
				col.gameObject.transform.Rotate (0f, 0f,-90.289f);
			}
		}
	}
}
