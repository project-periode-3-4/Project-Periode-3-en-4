using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EPIC : MonoBehaviour {

	public bool dirUpRe = false;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("car").GetComponent<checkpoint>().dirUp){
			transform.Translate (Vector3.up * Time.deltaTime, Space.World);
            Debug.Log("hah2");
        }
		if (transform.position.y >= 42){
			dirUpRe = true;
			Debug.Log("hah");
		}
	}
}
