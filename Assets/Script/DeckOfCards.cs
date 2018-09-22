using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckOfCards : MonoBehaviour {

	List<int> cards;
	public IEnumerable<int> GetCards(){
		
		foreach (int i in cards){
			yield return i;
		}
	}


	public Vector3 start;
	public float cardOffset;
	public GameObject cardPrefab;


	// Use this for initialization
	void Start () {
		Shuffle ();
	}


	public void Shuffle(){
		if (cards == null) {
			cards = new List<int> ();
		}
		else {
			cards.Clear ();
		}

		for (int i = 0; i <52; i++) {
			cards.Add (i);
		}

		// make the list disarrangement
		int n = cards.Count;
		while (n > 1) {
			n--;
			int k = Random.Range (0,n+1);
			int temp = cards [k];
			cards [k] =  cards [n];
			cards [n] = temp; 
		}
	}


}