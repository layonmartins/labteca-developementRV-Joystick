using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSControler : MonoBehaviour {

    public float velocity = 0.7f;
    private CharacterController controller;
    public GameObject gameObject;
    private HUDController hud;
    private bool walking = true;


    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
        hud = gameObject.GetComponent<HUDController>();
    }
	
    void walk()
    {
        if (hud.mapUp == false && hud.tabletUp == false && hud.inventoryUp == false)
            walking = true;
        else
            walking =  false;
    }

    private void Update()
    {
        walk();
    }

    // Update is called once per frame
    void FixedUpdate () {
        
        Vector3 moveDirection = Camera.main.transform.forward;
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        transform.Rotate(0, h * velocity, 0);
        if(walking)
        controller.SimpleMove(v * moveDirection * velocity);
        
        
    }
}
