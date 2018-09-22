using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCtrl : MonoBehaviour {

	public static AudioCtrl instance;
	public GameAudio audios;

	[Tooltip("Use to on/off the audio of the game from Inspector")]
	public bool soundOn;
	public bool bgMusicOn;

	public GameObject bgMusic;



	// Use this for initialization
	void Start () {
		if (instance == null) {
			instance = this;
		}

		if(bgMusicOn){
			bgMusic.gameObject.SetActive (true);
		}
			
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CardShuffle(Vector3 pos){
		if (soundOn) {
			AudioSource.PlayClipAtPoint (audios.cardShuffle, pos,1f);
		}
	}
		
}