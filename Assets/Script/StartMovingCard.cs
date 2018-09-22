using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMovingCard : MonoBehaviour {

	public static StartMovingCard instance;
	public GameObject backCard;
	public Vector3 startPos;
	public Vector3 endPos;
	public float rate = 0.2f;
	public float secRate = 0.09f;

	public  bool isStart;
	int p1;
	int p2;

	public GameObject centerPanel;

	SpriteRenderer sp;

	void Awake(){

		sp = GetComponent<SpriteRenderer> ();

		if (instance == null) {
			instance = this;
		}
	}

//	public void ToggleFace(bool showFace){
//
//		for(int i=0; i=xList.Count; i++){
//			if (showFace) {
//				sp.sprite = xList [i].gameObject.GetComponent<SpriteRenderer> ().sprite;
//			}
//			
//		} if(!showFace) {
//			sp.sprite = backCard.gameObject.GetComponent<SpriteRenderer> ().sprite;
//		}
//	}


	public List<GameObject> xList = new List<GameObject> ();

	void Start () {
		p1=0;

		isStart =true;
		for (int i = 0; i < 52; i++) {
			GameObject x = Instantiate (backCard, transform.position, Quaternion.identity);

			xList.Add (x);
		}

		Invoke ("cStart", 0.5f);

	}

	void cStart(){
		if(isStart)
			StartCoroutine(FixTimeToRunBottom (rate));
		 
	}

	IEnumerator FixTimeToRunBottom(float time2) {
		
		int s = 0;

		while (s < 52) {

				yield return new WaitForSeconds (secRate);

				endPos = new Vector3 (0f, 0f, 0.0f);

			StartCoroutine (MoveToBottom (xList [s], endPos, rate));

				s++;

			}
		isStart = false;
		StartCoroutine (FixTimeToRun(rate));

		}


	IEnumerator MoveToBottom(GameObject theGO, Vector3 position, float time) {
		
		Vector3 start = theGO.transform.position;
		Vector3 end = position;
		float t = 0;

		while(t < 1) {
			yield return null;
			t += Time.deltaTime / time;
			theGO.transform.position = Vector3.Lerp(start, end, t);
		}
		theGO.transform.position = end;
			}

		
	IEnumerator FixTimeToRun(float time2) {

		int s = 0;

		while (s < 52) {



			//first player
			if (p1 < 13) {
				AudioCtrl.instance.CardShuffle (gameObject.transform.position);
				yield return new WaitForSeconds (secRate);

				endPos = new Vector3 (8.05f, -0.219f, 0.0f);
				endPos = new Vector3 (8.0f, -0.200f, 0.0f);

				StartCoroutine (MoveTo (xList [s], endPos, rate));

				s++;
				p1++;
			}

			// Second Player
			else if (p1 >= 13 && p1 < 26) {
				AudioCtrl.instance.CardShuffle (gameObject.transform.position);
				endPos = new Vector3 (0f, 3.12f, 0.0f);

				yield return new WaitForSeconds (secRate);

				StartCoroutine (MoveTo (xList [s], endPos, rate));
				s++;
				p1++;

			}
			// Third Player
			else if (p1 >= 26 && p1 < 39) {
				AudioCtrl.instance.CardShuffle (gameObject.transform.position);
				endPos = new Vector3 (-7.5f, -0.219f, 0.0f);

				yield return new WaitForSeconds (secRate);

				StartCoroutine (MoveTo (xList [s], endPos, rate));
				s++;
				p1++;

			}
			// Forth Player
			else if (p1 >= 39 && p1 < 52) {
			//	AudioCtrl.instance.CardShuffle (gameObject.transform.position);
				endPos = new Vector3 (0f, -3.71f, 0.0f);

				yield return new WaitForSeconds (secRate);

				StartCoroutine (MoveTo (xList [s], endPos, rate));
				s++;
				p1++;

			}

		}
		centerPanel.SetActive (true);
		//Destroy(AudioCtrl.instance.audios.cardShuffle);
	}

	IEnumerator MoveTo(GameObject theGO, Vector3 position, float time) {
		Vector3 start = theGO.transform.position;
		Vector3 end = position;
		float t = 0;

		//float a = gameObject.transform.position.x;
		//a += 2f;

		//int x;
		//gameObject.transform.Rotate (new Vector3(gameObject.transform.rotation.x,gameObject.transform.rotation.y,gameObject.transform.rotation.z));


		while(t < 1) {
			yield return null;
			t += Time.deltaTime / time;
			theGO.transform.position = Vector3.Lerp(start, end, t);
		}
		theGO.transform.position = end;

	}

}
