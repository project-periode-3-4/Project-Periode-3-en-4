using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {

	public Canvas pauseMenu;

	// Use this for initialization
	void Start () {

		pauseMenu.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Escape)){
			if(Time.timeScale == 0){
				
			}
			else {
				Time.timeScale = 0;
				pauseMenu.enabled = true;
			}
		}

	}

	public void cont () {
		pauseMenu.enabled = false;
		Time.timeScale = 1;
	}

	public void exit () {
		Application.LoadLevel ("Home");
		Time.timeScale = 1;
	}
}
