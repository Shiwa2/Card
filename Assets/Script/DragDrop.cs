using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour {

	private bool draggingItem = false;
	private GameObject draggedObject;
	private Vector2 touchOffset;
	public Vector3 box1start,box1end,startbox2,box2end,startbox3,box3end,startbox4,box4end,box1starty,box1endy;
	public GameObject box1;
	void Start(){
		box1start = new Vector3( -2.5f,2.9f,0f);
		box1end = new Vector3(-5.21f,1.89f,0f);
		box1starty = new Vector3( -2.5f,3.47f,0f);
		box1endy = new Vector3(-5.21f,1.98f,0f);
//		startbox2= 2f;
//		box2end= -2.81f;
//		startbox3 = -2.65f;
//		box3end = 2.67f;
//		startbox4 = -2.47f;
//		box4end = 2.32f;
	}

	void Update ()
	{
		if (HasInput)
		{
			DragOrPickUp();
		}
		else
		{
			if (draggingItem)
				DropItem();
		}
	}
	Vector2 CurrentTouchPosition
	{
		get
		{
			return Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
	}
	private void DragOrPickUp()
	{
		var inputPosition = CurrentTouchPosition;
		if (draggingItem)
		{
			draggedObject.transform.position = inputPosition + touchOffset;
		}
		else
		{
			RaycastHit2D[] touches = Physics2D.RaycastAll(inputPosition, inputPosition, 0.5f);
			if (touches.Length > 0)
			{
				var hit = touches[0];
				if (hit.transform != null) {
					if (hit.collider.gameObject.CompareTag ("Wood")) {
						draggingItem = true;
						draggedObject = hit.transform.gameObject;
						touchOffset = (Vector2)hit.transform.position - inputPosition;
						draggedObject.transform.localScale = new Vector3 (0.5f, 0.3f, 0.5f);
					}
				}
			}
		}
	}
	private bool HasInput
	{
		get
		{
			// returns true if either the mouse button is down or at least one touch is felt on the screen
			return Input.GetMouseButton(0);
		}
	}
	void DropItem(){
		draggingItem = false;
		draggedObject.transform.localScale = new Vector3(0.5f, 0.3f, 0.5f);
		if(draggedObject.gameObject.transform.position.x> box1start.x && draggedObject.gameObject.transform.position.x< box1end.x && draggedObject.gameObject.transform.position.y < box1starty.y && draggedObject.gameObject.transform.position.y > box1endy.y){
				draggedObject.gameObject.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezePositionX;
	}
	}

}