using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Pause : MonoBehaviour
{
    public bool isPaused;
    public GameObject pauseCanvas;
    public GameObject pauseCanvasKlein;
    public GameObject optionsCanvas;
    public bool menutoggle;

    void Start()
    {
        Terug();
    }

    // Update is called once per frame
    void Update()
    {//als de esc key wordt ingedrukt komt het canvas pause aan te staan
        if (isPaused)
        {
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
            pauseCanvas.SetActive(true);
            Time.timeScale = 0;
            menutoggle = true;
            PlayerPrefs.SetInt("menu", 1);
        }
        if (!isPaused && PlayerPrefs.GetInt("menu") == 0)
        {
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = true;
            pauseCanvas.SetActive(false);
            Time.timeScale = 1;
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            if (menutoggle == true)
            {
                PlayerPrefs.SetInt("menu", 0);
            }
            if (menutoggle == false)
            {
                PlayerPrefs.SetInt("menu", 1);
            }
        }
    }

    public void Resume()
    {
        isPaused = false;
    }

    public void Options()
    {
        pauseCanvasKlein.SetActive(false);
        optionsCanvas.SetActive(true);
    }

    public void Terug()
    {
        pauseCanvasKlein.SetActive(true);
        optionsCanvas.SetActive(false);
    }
}
