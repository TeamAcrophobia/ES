using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Level1Interaction : MonoBehaviour {
	
	public float gazeTime = 2.0f;

	private float timer;

	private bool gazedAt;

	public GameObject Level1;

	public GameObject Level2;

	public GameObject Level3;

	public GameObject Level4;

	public GameObject Level5;

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

		if(Level1.transform.name=="AnxietyLevel1"){
			Debug.Log ("Sample");
		}

		else if(Level2.transform.name=="AnxietyLevel2"){
			Debug.Log ("Sample2");
		}

		else if(Level3.transform.name=="AnxietyLevel3"){
			Debug.Log ("Sample3");
		}

		else if(Level4.transform.name=="AnxietyLevel4"){
			Debug.Log ("Sample4");
		}

		else if(Level5.transform.name=="AnxietyLevel5"){
			Debug.Log ("Sample5");
		}
	}
}
