using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandCtrl : MonoBehaviour {

	public enum CoinFx
	{
		vanish,
		fly
	}
		
	public float speed;
	public bool startFlying;
	public Text txtUs;
	public CoinFx coinFx;

	// Use this for initialization
	void Start () {
		startFlying = false;
		if (coinFx == CoinFx.fly) {
			txtUs = GameObject.Find ("txt-Hand").GetComponent<Text> ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (startFlying) {
			transform.position = Vector3.Lerp (transform.position,txtUs.transform.position,speed);
		}

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (coinFx == CoinFx.fly) {
			startFlying = true;
		//	GameCtrl.instance.UpdataHand ();

		}
	}
}
