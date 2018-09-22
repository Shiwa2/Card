using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

//	private bool draggingItem = false;
	public static InputManager instance;
	private GameObject draggedObject;
	private Vector2 touchOffset;
	bool isSelected;
	public List<GameObject> objects;

	void Awake(){
		if (instance == null)
			instance = this;
	}

	void Update (){
		if (HasInput)
		{
			DragOrPickUp();

		}
	}


	Vector2 CurrentTouchPosition{
		get{
			return Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
	}

	private void DragOrPickUp(){
		var inputPosition = CurrentTouchPosition;
			RaycastHit2D[] touches = Physics2D.RaycastAll(inputPosition, inputPosition, 0.5f);
			if (touches.Length > 0)
			{
				var hit = touches[0];
			if (hit.transform != null) { 
				if (hit.collider.gameObject.CompareTag ("Wood")) {
					draggedObject = hit.transform.gameObject;
					draggedObject.transform.localScale = new Vector3 (0.5f, 0.3f, 0.5f);
					objects.Add (hit.transform.gameObject);
				}
			}
		}
	}

	private bool HasInput
	{
		get
		{
			return Input.GetMouseButton(0);
		}
	}
}
