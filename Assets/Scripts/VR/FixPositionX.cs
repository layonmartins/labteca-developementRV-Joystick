using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPositionX : MonoBehaviour {

   // public GameObject cardboardmain;
    public GameObject cameramain;
    public GameObject bola;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //fix position X and rotation

        Vector3 newPosition = bola.transform.position;
        Quaternion newRotation = bola.transform.rotation;
        newPosition.y = 1.185f;
        newRotation.x = 0f;
        newRotation.z = 0f;
        transform.position = newPosition;
        transform.rotation = newRotation;


    }
}
