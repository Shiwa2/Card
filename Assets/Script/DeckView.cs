using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DeckOfCards))]
public class DeckView : MonoBehaviour {

	DeckOfCards deck;
	public Vector3 start;
	public float cardOffset;
	public GameObject cardPrefab;


	// Use this for initialization
	void Start () {
		deck = GetComponent<DeckOfCards>();
		ShowCards ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowCards (){
		int cardCount = 0;
		foreach (int i in deck.GetCards()) {
			float co = cardOffset * cardCount;

			GameObject a; 
			Vector3 temp = start = new Vector3 (co,0f);
			//a.transform.position = temp;
		}
	}
}
