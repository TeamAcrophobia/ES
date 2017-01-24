using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class VRAutoWalk : MonoBehaviour {
	//how fast to move
	public float speed = 50.0f;
	//Should the Character Controller forward or not?
	public bool moveFoward;
	//CharacterController script
	private CharacterController controller;
	//GvrViewerMain Script
	private GvrViewer gvrViewer;
	//VR Head 
	private Transform vrHead;

	// Use this for initialization
	void Start () {
		//Find the CharacterController
		controller = GetComponent<CharacterController>();
		gvrViewer = transform.GetChild (0).GetComponent<GvrViewer> ();
		vrHead = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			//Change the state of moveForward
			moveFoward = !moveFoward;
		}
		if(moveFoward){
			Vector3 forward = vrHead.TransformDirection (Vector3.forward);
			controller.SimpleMove (forward * speed);
		}
	}
}
