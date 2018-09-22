using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnAudio : MonoBehaviour {

	public AudioSource As;

	// Use this for initialization
	void Start () {
		As = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayMusic(AudioClip other){
		As.PlayOneShot (other, 1);
	}
}
