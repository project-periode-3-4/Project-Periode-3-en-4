using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public GameObject kamer1;
    public GameObject kamer2;
    public GameObject kamer3;
    public GameObject kamer4;
    public GameObject kamer5;
    public GameObject kamer6;
    public GameObject kamer7;
    public GameObject kamer8;

    // Use this for initialization
    void Start()
    {
        kamer1.SetActive(false);
        kamer2.SetActive(false);
        kamer3.SetActive(false);
        kamer4.SetActive(false);
        kamer5.SetActive(false);
        kamer6.SetActive(false);
        kamer7.SetActive(false);
        kamer8.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("scherm") == "dashboard")
        {
            kamer1.SetActive(false);
            kamer2.SetActive(false);
            kamer3.SetActive(false);
            kamer4.SetActive(false);
            kamer5.SetActive(false);
            kamer6.SetActive(false);
            kamer7.SetActive(false);
            kamer8.SetActive(false);
        }
        if (PlayerPrefs.GetString("scherm") == "elearning")
        {
            kamer1.SetActive(true);
            kamer2.SetActive(false);
            kamer3.SetActive(false);
            kamer4.SetActive(false);
            kamer5.SetActive(false);
            kamer6.SetActive(false);
            kamer7.SetActive(false);
            kamer8.SetActive(false);
        }
        if (PlayerPrefs.GetString("scherm") == "presentie")
        {
            kamer1.SetActive(false);
            kamer2.SetActive(true);
            kamer3.SetActive(false);
            kamer4.SetActive(false);
            kamer5.SetActive(false);
            kamer6.SetActive(false);
            kamer7.SetActive(false);
            kamer8.SetActive(false);
        }
    }
}
