using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedInputObjectInteration : MonoBehaviour, TimedInputHandler {

    private InteractObjectBase objectInteration;
    private HUDController hudcontroller;
    private GameObject player;
    public bool interable = true;
    private AudioSource buttonpress;

    // Use this for initialization
    void Start () {
        objectInteration = GetComponent<InteractObjectBase>();
        hudcontroller = GameObject.Find("GameController").GetComponent<HUDController>();
        player = GameObject.Find("Player");
        buttonpress = GameObject.Find("AudioButtonPress").GetComponent<AudioSource>();
    }
	
    void isInterable()
    {
        //check if some HUD controller is active, if yese, so desactive all objctes interables
        if (hudcontroller.tabletUp == true || hudcontroller.mapUp == true || hudcontroller.inventoryUp == true)
            interable = false;
        else if (Vector3.Distance(player.transform.position, transform.position) > 2) //Check if player is near of this object
            interable = false;
        else
            interable = true;
    }

	// Update is called once per frame
	void Update () {
        isInterable();
        if (interable)
            gameObject.layer = 16;
        else
            gameObject.layer = 0;
	}

    public void HandleTimedInput()
    {
        buttonpress.Play();
        objectInteration.Interact();
    }
}
