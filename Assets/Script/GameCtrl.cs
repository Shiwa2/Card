using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;



public class GameCtrl : MonoBehaviour {

	public static GameCtrl instance;
	public GameData data;
	string dataFilePath;
	BinaryFormatter bf;
	public Text textHands;


	void Awake(){
		if (instance == null) {
			instance = this;
		}
//		bf = new BinaryFormatter ();
//		dataFilePath = Application.persistentDataPath + "/CardGame.bat";

	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
//	void Update () {
//		if (Input.GetKeyDown (KeyCode.Escape)) {
//			ResetData ();
//		}
//		
//	}
//
//	void SaveData(){
//		FileStream fs = new FileStream (dataFilePath , FileMode.Create);
//		bf.Serialize (fs,data);
//		fs.Close ();
//	}
//
//	void LoadData(){
//		if (File.Exists (dataFilePath)) {
//			FileStream fs = new FileStream (dataFilePath,FileMode.Open);
//			data = (GameData)bf.Deserialize (fs);
//			textHands.text = " " + data.hand;
//			fs.Close ();
//		}
//	}
//
//	void ResetData(){
//		FileStream fs = new FileStream (dataFilePath , FileMode.Create);
//		data.hand = 0;
//		textHands.text = "" + data.hand;
//		bf.Serialize (fs,data);
//		fs.Close ();
//	}
//
//	void OnEnable(){
//		LoadData ();
//	}
//
//	void OnDisable(){
//		SaveData ();
//	}
//
//	public void UpdataHand(){
//		data.hand += 1;
//		textHands.text = "" + data.hand;
//	}
}
