using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLookWalk : MonoBehaviour {

    public float velocity = 0.7f;
    public bool isWalking = false;
    private CharacterController controller;
    
    
    

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isWalking)
        {
            controller.SimpleMove(Camera.main.transform.forward * velocity);
            
        }
       
       
    }
}
