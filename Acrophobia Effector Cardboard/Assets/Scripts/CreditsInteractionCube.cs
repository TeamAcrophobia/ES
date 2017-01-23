using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CreditsInteractionCube : MonoBehaviour {

	public float gazeTime = 2.0f;

	private float timer;

	private bool gazedAt;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(gazedAt){
			timer += Time.deltaTime;

			if(timer >= gazeTime){
				ExecuteEvents.Execute (gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);
				timer = 0f;
			}
		}
	}

	public void PointerClick(){
		SceneManager.LoadScene (1);
	}
}
