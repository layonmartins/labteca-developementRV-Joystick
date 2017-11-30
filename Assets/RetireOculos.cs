using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RetireOculos : MonoBehaviour {

    public Canvas canvasRetirarOculos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<TextMesh>().text == "7.00")
        {
            canvasRetirarOculos.GetComponent<CanvasGroup>().alpha = 0.8f;
        }
        
	}
}
