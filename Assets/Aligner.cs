using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aligner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // use the oculus go forward direction
        //transform.position = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        transform.rotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);
    }
}
