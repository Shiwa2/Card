using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OkCtrl : MonoBehaviour {

	public static OkCtrl instance;

	public  Text showText;
	public Text themText;
	public Text themText2;
	public Text handText;
	public Text usText;
	public Text USText2;

	public bool players;
	public bool player1;
	public bool player2;
	public bool player3;
	public bool player4;
	public bool pressOk;
	public bool pressReload;

	public static int b;
	int y;

	public GameObject btnReload;
	public GameObject btnPluse;
	public GameObject btnMines;
	public GameObject panel;

	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}


	// Use this for initialization
	void Start () {

		players = true;
		player1 = true;
		player2 = true;
		player3 = true;
		player4 = true;
		pressOk = false;
		pressReload = false;
		b = 0;
	}

		
	public void Ok(){
		
		if (player1) {
			//first time that press ok

			showText.text = ArabicSupport.ArabicFixer.Fix("بازیکن دوم");
			handText.text = " ";
			usText.text = " " + ChangeNum.Value;
			b += ChangeNum.Value;
			ChangeNum.Value = 0;
			player1 = false;
			print (b);
		} else if (player2 == true) {
				
			//second time that press ok
			b += ChangeNum.Value;
			showText.text = ArabicSupport.ArabicFixer.Fix ("بازیکن سوم");
			handText.text = " ";
			themText.text = " " + ChangeNum.Value;
			ChangeNum.Value = 0;
			player2 = false;


		} else if (player3 == true) {
					
			//third time that press ok

			showText.text = ArabicSupport.ArabicFixer.Fix ("بازیکن چهارم");
			handText.text = (13 - (int.Parse (themText.text) + int.Parse (usText.text) + ChangeNum.Value)).ToString ();
			b += ChangeNum.Value;

			y = ChangeNum.Value + int.Parse (usText.text);
			usText.text = " " + y;
			btnReload.SetActive (true);
			btnPluse.SetActive (false);
			btnMines.SetActive (false);
			player3 = false;
			player4 = true;
			pressOk = true;
			
		} else if (player4 == true) {
			b += ChangeNum.Value;

			PressBtn ();

		}
	}

	int a = 1;
	public void PressBtn (){

		if (pressOk){
			int z = int.Parse(handText.text) + int.Parse (themText.text);
			themText.text = "" + z;
			pressOk = false;
			player4 = false;	
			panel.SetActive (false);

		} else if (pressReload == false) {
			themText.text = (int.Parse(usText.text) + a).ToString ();
			USText2.text = (13-int.Parse(themText2.text)).ToString ();
		
		    panel.SetActive (false);
			pressReload = false;

		}


	}
}

