using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimedInputLocomotion : MonoBehaviour, TimedInputHandler, TimedInputHandlerLocomotion
{
    public GameObject player;
    private HeadLookWalk headlookwalk;
    private CanvasGroup canvasgroup;

	// Use this for initialization
	void Start () {
        headlookwalk = player.GetComponent<HeadLookWalk>();
        canvasgroup = GetComponent<CanvasGroup>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

  

    public void HandleTimedInput()
    {
        
        headlookwalk.isWalking = true;
        canvasgroup.alpha = 0.8f;
    }

    public void HandleTimedInputExit()
    {
        
        headlookwalk.isWalking = false;
        canvasgroup.alpha = 0.4f;
    }
}
