using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Links : MonoBehaviour {

	public void twiter(){
		Application.OpenURL ("https://twitter.com/ShiwaQadernia");
	}

	public void LinkedIn(){
		Application.OpenURL ("https://www.linkedin.com/feed/");
	}

	public void GitHub(){
		Application.OpenURL ("https://github.com");
	}
}
