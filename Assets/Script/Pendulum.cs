using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour {

	Rigidbody2D rb;

//	public float leftPushRang;
//	public float rightPushRang;
	public float velocityThreshold;

	public float[] values;
	public GameObject arrow;
	public GameObject wood1;
	public GameObject wood2;
	public GameObject wood3;
	public GameObject wood4;
	public GameObject wood5;
	public GameObject wood6;
	public GameObject wood7;
	public GameObject wood8;
	public GameObject wood9;
	public GameObject wood10;
	public GameObject wood11;
	public GameObject wood12;
	public GameObject wood13;

	public GameObject crown1;
	public GameObject crown2;
	public GameObject crown3;
	public GameObject crown4;

	public GameObject return1;
	public GameObject return2;
	public GameObject return3;
	public GameObject return4;
	int i;

	public float posZ;
	Quaternion rot;
	float store;

	// Use this for initialization
	void Start () {
		 i = Random.Range (0,values.Length);
		posZ = values [i];

		rot = transform.rotation;
		rb = GetComponent<Rigidbody2D> ();
		int r = Random.Range (4,10);

		Invoke ("TurnToFalse",r);

	}

	public void TurnToFalse(){
		GetComponent<Rigidbody2D> ().simulated = false;
		transform.rotation = rot*Quaternion.Euler(0,0,values[i]);

		Invoke("trues",0.5f);
		Invoke("trueAll",0.5f);
	}

	void trueAll(){

		gameObject.SetActive (false);
		wood1.SetActive (true);
		wood2.SetActive (true);
		wood3.SetActive (true);
		wood4.SetActive (true);
		wood5.SetActive (true);
		wood6.SetActive (true);
		wood7.SetActive (true);
		wood8.SetActive (true);
		wood9.SetActive (true);
		wood10.SetActive (true);
		wood11.SetActive (true);
		wood12.SetActive (true);
		wood13.SetActive (true);



	}
	void trues(){

		if(i == 0 ){
			print ("ok1");
			store = 0;
			crown3.SetActive(true);
			return3.SetActive(true);
		}else if(i == 1){
			print ("ok2");
			store = 90;
			crown4.SetActive(true);
			return4.SetActive(true);
		}else if(i == 2){
			store = 180;
			print ("ok3");
			crown1.SetActive(true);
			return1.SetActive(true);
		}else if(i == 3){
			store = 270;
			print ("ok4");
			crown2.SetActive(true);
			return2.SetActive(true);
		}
	}
}


