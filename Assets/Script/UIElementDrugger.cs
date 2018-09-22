using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;

public class UIElementDrugger : MonoBehaviour {

	public const string DRUGEBLE_TAG = "Wood";
	private bool dragging = false;
	private Vector2 orignalPosition;
	private Transform objectToDrag;
	private Image objectToDragImage;
	List<RaycastResult> hitObjects = new List<RaycastResult> ();

	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			objectToDrag = GetDraggableTransformFromUnderMouse ();
			if(objectToDrag != null){
				dragging = true;
				objectToDrag.SetAsLastSibling ();
				orignalPosition = objectToDrag.position; 
				objectToDragImage = objectToDrag.GetComponent<Image> ();
				objectToDragImage.raycastTarget = false;
			}
		}

		if(dragging){
			objectToDrag.position = Input.mousePosition;
		}

		if(Input.GetMouseButtonUp(0)){
			if(objectToDrag != null){
				Transform objectToReplace = GetDraggableTransformFromUnderMouse ();
				if (objectToReplace != null) {
					objectToDrag.position = objectToReplace.position;
					objectToReplace.position = orignalPosition;
				} else {
					objectToDrag.position = orignalPosition;
				}
				objectToDragImage.raycastTarget = true;
				objectToDrag = null;
			}
			dragging = false;
		}
	}

	private GameObject GetObjectUnderMouse(){
		var pointer = new PointerEventData (EventSystem.current);
		pointer.position = Input.mousePosition;
		EventSystem.current.RaycastAll (pointer,hitObjects);
		if (hitObjects.Count <= 0) 
			return null;
		return hitObjects.First ().gameObject;

	}

	private Transform GetDraggableTransformFromUnderMouse(){
		GameObject clickedObject = GetObjectUnderMouse ();
		if (clickedObject != null && clickedObject.tag == "Wood") {
			return clickedObject.transform;
		}
		return null;
	}
}
