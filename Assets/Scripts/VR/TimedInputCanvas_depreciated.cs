using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedInputCanvasButtons : MonoBehaviour, TimedInputHandler {

    public GameController gameController;
    public string button;
    private HUDController hudController;

	// Use this for initialization
	void Start () {
        hudController = gameController.GetComponent<HUDController>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    

    public void HandleTimedInput()
    {
        if (button.Equals("InventoryButton"))
        {
            Debug.Log("CallInventoryButton");
            hudController.CallInventoryTrigger();
        } else if (button.Equals("JournalButton"))
        {
            Debug.Log("CallJournalButton");
            hudController.CallTabletTrigger();
        } else if (button.Equals("MapButton"))
        {
            hudController.CallMapTrigger();

        } else
        {
            //ExitCurrentstate();
        }
        
    }
}
