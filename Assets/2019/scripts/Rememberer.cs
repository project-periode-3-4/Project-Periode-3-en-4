using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rememberer : MonoBehaviour {

    public Text memoryShort;
    public Text memoryLong;
    public string thoughts;
    public Text highscore;

	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(this.gameObject);
        
    }
	
	// Update is called once per frame
	void Update () {
        memoryLong = memoryShort;
        thoughts = memoryShort.text;
        highscore.text = thoughts;
        //GameObject.FindGameObjectWithTag("Highscore");
    }
}
