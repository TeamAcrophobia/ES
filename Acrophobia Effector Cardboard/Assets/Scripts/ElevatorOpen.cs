using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ElevatorOpen : MonoBehaviour {

	public float gazeTime = 2.0f;

	private float timer;

	private bool gazedAt;

	private bool isElevatorOpen = false;

	public GameObject elevatorOpenObject;

	public GameObject elevatorOpenObject1;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(gazedAt && (elevatorOpenObject1.name=="RDoor" || elevatorOpenObject.name == "LDoor")){
			
			timer += Time.deltaTime;

			if(timer >= gazeTime){
				ExecuteEvents.Execute (gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerEnterHandler);
				timer = 0f;
			}
		}
	}

	public void PointerEnter(){

		if (!isElevatorOpen) {
			elevatorOpenObject = GameObject.Find ("LDoor");
			elevatorOpenObject.GetComponent<Animation> ().Play ("Elevator1OpenLeft");
			elevatorOpenObject1 = GameObject.Find ("RDoor");
			elevatorOpenObject1.GetComponent<Animation> ().Play ("Elevator1OpenRight");
			isElevatorOpen = true;
		}
	}
}
