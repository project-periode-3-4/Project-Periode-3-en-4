using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    public GameObject paneltext;
    bool textActive;

    // Start is called before the first frame update
    void Start()
    {
        textActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && textActive == true)
        {
            paneltext.SetActive(false);
            textActive = false;
        } //else if (Input.GetKeyDown(KeyCode.KeypadEnter) && textActive == false) {
            //paneltext.SetActive(true);
            //textActive = true;
        //}
    }
}
