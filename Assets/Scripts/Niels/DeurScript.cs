using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeurScript : MonoBehaviour
{

    public GameObject deur_elearn;
    public GameObject deur_pres;

    // Use this for initialization
    void Start()
    {
        deur_elearn.SetActive(true);
        deur_pres.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("scherm") == "elearning")
        {
            deur_elearn.SetActive(false);
            deur_pres.SetActive(true);
        }
        if (PlayerPrefs.GetString("scherm") == "presentie")
        {
            deur_elearn.SetActive(true);
            deur_pres.SetActive(false);
        }
        if (PlayerPrefs.GetString("scherm") == "dashboard")
        {
            deur_elearn.SetActive(true);
            deur_pres.SetActive(true);
        }
    }
}
