using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodCtrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			Vector3 pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (pos, Vector2.zero);
			if(hit != null && hit.collider != null){
				if(hit.collider.gameObject.CompareTag("Box")){
					transform.position = Vector3.Lerp (transform.position,hit.collider.gameObject.transform.position,1f);
				}
			}
		}
	}
}
