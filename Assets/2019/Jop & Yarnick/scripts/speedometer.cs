using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedometer : MonoBehaviour {

    Rigidbody rb;
    public Texture2D Background;
    public Texture2D needle;
    public Text kphDisplay;

    public RectTransform pos;
    public float w;
    public float h;

    double kph = 0;
    public static float kmh;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        //pos.position = new Vector2(Screen.width - w, Screen.height - h);
	}
	
	// Update is called once per frame
	void Update () {
        kph = rb.velocity.magnitude * 3.6;
        kmh = (float)kph;
        kmh = Mathf.Round(kmh * 10) / 10;
        kphDisplay.text = kmh + " KPH";

        analogueneedke.ShowSpeed(kmh, 0, 100);
    }
}