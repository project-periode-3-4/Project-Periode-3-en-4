using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadetowhite : MonoBehaviour {
    private MeshRenderer MeshRenderer;
    private float transparentsy = 0f;
    private float buttonPressed = 0f;
    private float fading = 0f;
	// Use this for initialization
	void Start ()
    {
        MeshRenderer = GetComponent<MeshRenderer>(); 
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        MeshRenderer.material.SetColor("_Color", new Vector4(255, 255, 255, transparentsy));
        if (buttonPressed == 1)
        {
            fading = 1f; 
        }

        if (fading == 1f)
        {
            transparentsy = transparentsy + 0.0001f;
            if (transparentsy >= 255)
            {
                fading = 0f;
            }
        }
     
}
    public void changeAlbedo()
    {
        buttonPressed = 1f;
    }
    public void reset()
    {
        buttonPressed = 0f;
        fading = 0f;
        transparentsy = 0f;

    }
}
