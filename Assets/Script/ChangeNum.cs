 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNum : MonoBehaviour {

	public static ChangeNum instance;
	public static int Value = 0;
	public Text TextObject = null;
	public bool canIncrement;
	public int x ;

	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}


	// Update is called once per frame
	void Update () {
		canIncrement = true;
	}

	public void Increment(){
		
		if (canIncrement == true) {
			if (Value < 13-OkCtrl.b) {
				++Value;
				x = Value;
					
			}
			if (TextObject != null) {
				
				TextObject.text = Value.ToString ();
			}
		}
		canIncrement = false;
	}


	public void Decrement()
	{
		if (TextObject != null)
		{
			if (Value > 0) {
				--Value;
			}
			TextObject.text = Value.ToString();
		}
	}
		
}
