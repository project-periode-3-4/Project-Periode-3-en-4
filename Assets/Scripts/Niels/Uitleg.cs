using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Uitleg : MonoBehaviour
{
    public Text uitleg;
    public int progress;
    public Text buttontext;
    public GameObject canvasuitleg;
    public bool togglemenu;
    public GameObject DashboardSound;
    public GameObject DashboardPanel;
    //public GameObject PresentieSound;
    public GameObject PresentiePanel;
    //public GameObject ElearningSound;
    public GameObject ElearningPanel;
    public GameObject Progress;
    public bool add;
    public GameObject quizbutton;

    // Use this for initialization
    void Start()
    {
        MenuAan();
        uitleg.text = "Welkom in deze game. Dit spel gaat je een basic uitleg geven over het gebruik van OnderwijsOnline.";
        buttontext.text = "Volgende";
        Progress = GameObject.Find("UICanvas");
        quizbutton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PlayerPrefs.GetInt("menu"));
        if (progress == 1)
        {
            uitleg.text = "Je kunt in deze game rondlopen met de W, A, S, D toetsen. W en S zorgen voor het voor en achteruit bewegen en A en D zorgen voor het naar links en rechts bewegen. Je kunt om je heen kijken door met je muis te bewegen. Als er om een interactie wordt gevraagd zal de toets die je hiervoor moet indrukken E zijn, dit staat dan ook nog op het scherm vermeld.";
        }
        if (progress == 2)
        {
            uitleg.text = "Als eerste opdracht, loop naar de computer toe, en start zet het scherm aan door op E te drukken zodra je in de buurt komt.";
            buttontext.text = "Aan de slag";
        }
        if (progress == 3)
        {
            Uit();
        }
        if (progress == 4)
        {
            MenuAan();
            canvasuitleg.SetActive(true);
            uitleg.text = "De deur van het geklikte onderwerp is nu open, loop er naar toe";
            buttontext.text = "Aan de slag";
        }
        if (progress == 5)
        {
            Uit();
            Debug.Log("uit");
        }
        if (progress == 6)
        {
            MenuAan();
            canvasuitleg.SetActive(true);
            uitleg.text = "Dit scherm zou nu duidelijk moeten zijn. Ga terug naar het dashboard scherm om de andere kamer te openen";
            buttontext.text = "Aan de slag";
        }
        if (progress == 7)
        {
            Uit();
            Debug.Log("uit");
        }
        if (progress == 8)
        {
            MenuAan();
            canvasuitleg.SetActive(true);
            uitleg.text = "Dit was de laatste opdracht van de staat van de game nu. Je kan nu de quiz maken!";
            buttontext.text = "Aan de slag";
        }
        if (progress == 9)
        {
            Uit();
            Debug.Log("uit");
            quizbutton.SetActive(true);
        }
    }

    public void MenuAan()
    {
        GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
        togglemenu = true;
        PlayerPrefs.SetInt("menu", 1);
        add = false;
    }

    public void Klik()
    {
        progress++;
        //Debug.Log(progress);
    }

    public void Uit()
    {
        canvasuitleg.SetActive(false);
        if (togglemenu == true)
        {
            PlayerPrefs.SetInt("menu", 0);
            togglemenu = false;
        }
        if (add == false && progress != 3)
        {
            Progress.GetComponent<ProgressBar>().CurrentQuestions++;
            add = true;
        }
    }

    public void KlikDashboard()
    {
        progress++;
        DashboardSound.SetActive(true);
        DashboardPanel.SetActive(false);
    }

    public void KlikPresentie()
    {
        progress++;
        //PresentieSound.SetActive(true);
        PresentiePanel.SetActive(false);
    }

    public void KlikElearning()
    {
        progress++;
        //ElearningSound.SetActive(true);
        ElearningPanel.SetActive(false);
    }
}
