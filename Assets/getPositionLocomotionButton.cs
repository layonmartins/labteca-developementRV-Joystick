using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getPositionLocomotionButton : MonoBehaviour {
    public GameObject locomotionButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 newPosition = locomotionButton.transform.position;
        Quaternion newRotation = locomotionButton.transform.rotation;
        transform.position = newPosition;
        transform.rotation = newRotation;
    }
}
