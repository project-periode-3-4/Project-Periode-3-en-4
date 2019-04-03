using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Levelmanager : MonoBehaviour {

    //public string levelToLoad;

    public static int speedoStatic;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadLevel(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void setSpeedo(int speedo)
    {
        speedoStatic = speedo;
    }
}
