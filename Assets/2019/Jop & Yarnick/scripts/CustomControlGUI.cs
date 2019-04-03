using UnityEngine;
using System.Collections;

public class CustomControlGUI : MonoBehaviour
{

    public float Value = 0.5f;
    public float Fade = 0.01f;

    public GUIBarScriptkmh GBS;

    void Start()
    {
        GBS = GetComponent<GUIBarScriptkmh>();
    }

    void Update()
    {
        //GBS.Value = ((Mathf.Sin (Time.time)/2f) + 0.5f) * 1.01f;
        Debug.Log(GBS.Value);
        GBS.Value = speedometer.kmh / 100;
    }
}
