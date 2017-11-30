using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedInputObjectPrefab : MonoBehaviour, TimedInputHandler {

    public GameObject inventoryItemPrefab;
    private Button scriptButton;
    private AudioSource buttonpress;

    // Use this for initialization
    void Start () {
        buttonpress = GameObject.Find("AudioButtonPress").GetComponent<AudioSource>();
        
    }
	
	// Update is called once per frame
	void Update () {
      
    }

    public void HandleTimedInput()
    {
        scriptButton = inventoryItemPrefab.GetComponent<Button>();
        buttonpress.Play();
        scriptButton.onClick.Invoke();
    }
}
