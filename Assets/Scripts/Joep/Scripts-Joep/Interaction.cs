using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class Interaction : MonoBehaviour
{

    public Transform player;
    public Text UItext;
    public float range;
    public string Message;
    public GameObject SchermCanvas;
    public string scherm;
    //public GameObject fpscontroller;
    //public GameObject UI;


    // Use this for initialization
    void Start()
    {
        UItext.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) <= range)
        {
            UItext.text = Message;
            if (Input.GetKeyDown(KeyCode.E))
            {
                DOTHIS();
                UItext.text = "";
                //fpscontroller.GetComponent<FirstPersonController>().enabled = false;
                GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
            }
        }
        if (Vector3.Distance(player.position, transform.position) >= range)
        {
            UItext.text = "";
        }

    }
    public void DOTHIS()
    {
        //print("DOTHISCUNT");
        //UI.SetActive(false);

        PlayerPrefs.SetString("onderwijsscherm", scherm);
        PlayerPrefs.SetInt("menu", 1);
        SchermCanvas.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
