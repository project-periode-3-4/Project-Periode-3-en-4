using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrows : MonoBehaviour {

	public GameObject arrow1;
	public GameObject arrow2;
	public GameObject arrow3;

	public Color colorStart = Color.red;
	public Color colorEnd = Color.yellow;
	public float duration = 1.0f;
	public Renderer rend;

	// Use this for initialization
	void Start () {
		arrow1 = GameObject.Find ("arrow1");
		arrow2 = GameObject.Find ("arrow2");
		arrow3 = GameObject.Find ("arrow3");

		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		float lerp = Mathf.PingPong(Time.time, duration) / duration;
		rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
	
	}
}
