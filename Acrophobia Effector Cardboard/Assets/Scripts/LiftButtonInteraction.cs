using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LiftButtonInteraction : MonoBehaviour {
    public float gazeTime = 2.0f;

    private float timer;

    private bool gazedAt;

    GameObject target;

    private bool isElevatorUp = false;

    private bool isPressedButton = false;

    // Use this for initialization
    void Start()
    {
        //do nothing herew
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

    public void PointClick()
    {
        if (isElevatorUp == false)
        {
            target = GameObject.Find("Lift");
            target.gameObject.GetComponent<Animation>().Play("Elevator1Up");
            isElevatorUp = true;
        }
    }

    public void PointerExit()
    {
        isPressedButton = false;
    }

    public void PointerEnter()
    {
        isPressedButton = true;
    }

}
