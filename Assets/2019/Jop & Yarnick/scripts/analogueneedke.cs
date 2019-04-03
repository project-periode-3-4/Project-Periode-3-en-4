using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class analogueneedke : MonoBehaviour {

    static float minAngle = 132f;
    static float maxAngle = -50f;
    static analogueneedke thisSpeedo;
    private RectTransform rect;

    // Use this for initialization
    void Start ()
    {
        thisSpeedo = this;
        rect = GetComponent<RectTransform>();
    }
	
	// Update is called once per frame
	public static void  ShowSpeed(float speed, float min, float max)
    {
        float ang = Mathf.Lerp(minAngle, maxAngle, Mathf.InverseLerp(min, max, speed));
        thisSpeedo.rect.transform.localRotation = Quaternion.Euler(0, 0, ang);
    }



    void Update()
    {

    }
}
