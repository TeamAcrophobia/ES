using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Plank1Interaction : MonoBehaviour {

	public bool isPlankShaking = false;

	public float gazeTime = 2.0f;

	private float timer;

	private bool gazedAt;

	GameObject target;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
	{
		if (gazedAt)
		{
			timer += Time.deltaTime;

			if (timer >= gazeTime)
			{
				ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);
				timer = 0f;
			}
		}
	}

	public void PointerEnter(){

		if(!isPlankShaking){
			target = GameObject.Find ("Plank1");
			target.gameObject.GetComponent<Animation> ().Play();
			isPlankShaking = true;
		}

	}

}
