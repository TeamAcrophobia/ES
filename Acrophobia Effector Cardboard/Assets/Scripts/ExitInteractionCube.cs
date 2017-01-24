using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExitInteractionCube : MonoBehaviour {

	public float gazeTime = 2.0f;

	private float timer;

	private bool gazedAt;

	public GameObject exitGameObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(gazedAt && exitGameObject.name=="Exit"){
			timer += Time.deltaTime;

			if(timer >= gazeTime){
				ExecuteEvents.Execute (gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);
				timer = 0f;
			}
		}
	}

	public void PointerClick(){
		Application.Quit ();
	}
}
