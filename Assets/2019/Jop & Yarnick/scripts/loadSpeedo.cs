using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadSpeedo : MonoBehaviour {

    public GameObject analogue;
    public GameObject digital;

    // Use this for initialization
    void Start () {
		if(Levelmanager.speedoStatic == 1)
        {
            analogue.SetActive(true);
            digital.SetActive(false);
        }
        else
        {
            analogue.SetActive(false);
            digital.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
