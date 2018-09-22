using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class QuizeManager : MonoBehaviour {
	public Questionary[] Question;
	int i=0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Questionary.instance.title

	}
	void questions(){
		//GetComponent<Button>.text = Question [i].CorrectAnswer;
		GetComponent<Text>().text=Question[i].title;

	}


}
