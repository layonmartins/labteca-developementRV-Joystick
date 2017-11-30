using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColliderLocomotionButton : MonoBehaviour {

    public GameObject player;
    private HeadLookWalk headlookwallk;
    private CharacterController characterController;

	// Use this for initialization
	void Start () {
       // headlookwallk = player.GetComponent<HeadLookWalk>();
        characterController = player.GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnCollisionEnter(Collision col)
    {
        //headlookwallk.isWalking = false;
        characterController.radius = 0.6f;
    }
    void OnCollisionExit(Collision col)
    {

        characterController.radius = 0.34f;
    }


}
