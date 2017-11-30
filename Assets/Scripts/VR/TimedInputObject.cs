using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedInputObject : MonoBehaviour, TimedInputHandler {

    public Button button;
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
        buttonpress.Play();
        button.onClick.Invoke();
    }
}
