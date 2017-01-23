using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteraction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PointerEnter(){
		Debug.Log ("Cube is detected");

	}

	public void PointerExit(){
		Debug.Log ("Cube is already out");

	}

	public void PointerClick(){
		Debug.Log ("Cube is detected");

	}
}
