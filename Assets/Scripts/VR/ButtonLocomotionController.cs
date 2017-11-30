using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLocomotionController : MonoBehaviour {

    public Canvas locomotion;
    public GameObject map;
    public Canvas inventory;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (map.activeSelf == false)
            locomotion.enabled = false;
        else
            locomotion.enabled = true;
	}
}
