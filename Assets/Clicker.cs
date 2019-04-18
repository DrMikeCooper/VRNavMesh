using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class Clicker : MonoBehaviour {

    public NavMeshAgent nv;
    public Transform controller;
    public Transform marker;
   
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update () {

        //if (EventSystem.current.IsPointerOverGameObject() == false)
        {
            RaycastHit hit;
            Ray ray = new Ray(controller.position, controller.forward);

            if (Physics.Raycast(ray, out hit))
            {
                if (marker)
                    marker.position = hit.point;

                if (Input.GetMouseButtonDown(0))
                    nv.SetDestination(hit.point);
            }
        }
	}
}
