using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedInputButtonPhMeter : MonoBehaviour, TimedInputHandler {

    private Image img;
    private Button button;
    public AudioSource beep;

    // Use this for initialization
    void Start () {
        img = this.gameObject.GetComponent<Image>();
        img.enabled = true;
        button = this.gameObject.GetComponent<Button>();
        this.gameObject.transform.GetChild(0).GetComponent<Text>().raycastTarget = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HandleTimedInput()
    {
        beep.Play();
        button.onClick.Invoke();
    }
}
