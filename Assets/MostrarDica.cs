using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarDica : MonoBehaviour {

    private GameObject player;
    private bool mostrar;
    private GameObject plaquinhaDica;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        plaquinhaDica = GameObject.Find("PlaquinhaDica");
        mostrar = true;
        plaquinhaDica.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(player.transform.position, transform.position) < 0.7f && mostrar)
        {
            StartCoroutine(MostraDica());
        }
    }

    IEnumerator MostraDica()
    {
        yield return new WaitForSecondsRealtime(120);
        mostrar = false;
        plaquinhaDica.SetActive(true);
    }
}
