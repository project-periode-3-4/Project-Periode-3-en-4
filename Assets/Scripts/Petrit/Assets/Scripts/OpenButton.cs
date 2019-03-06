using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenButton : MonoBehaviour {

    public Animation OpenDoor;
    public GameObject Openbutton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        OpenDoor.Play();
        Debug.Log("open");
    }
}
