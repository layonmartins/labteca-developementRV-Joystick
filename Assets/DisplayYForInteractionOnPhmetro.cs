﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayYForInteractionOnPhmetro : MonoBehaviour {

    private GameObject player;
    private GameObject displayE;
    private float seconds;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
        displayE = GameObject.Find("DisplayY");
        displayE.GetComponent<Text>().enabled = false;
        seconds = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 1.3f)
        {
            displayE.GetComponent<Text>().enabled = true;
        }

        seconds += Time.deltaTime;
        if (seconds > 1f)
        {
            displayE.GetComponent<Text>().enabled = false;
            seconds = 0;
        }

    }
}
