using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public float CurrentQuestions; // { get; set; }
    public float MaxQuestions; // { get; set; }
    public Slider Progress;

    // Verander maxquestions met het aantal vragen die we hebben
    void Start()
    {
        if (MaxQuestions == 0)
        {
            MaxQuestions = 3f;
        }

        CurrentQuestions = 0f;

        //Progress.value = CurrentQuestions;
    }

    // We moeten na elke vraag die we goed hebben bijv vraagGoed() returnen, zodat we If(vraagGoed) kunnen doen ipv getkeydown
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            CurrentQuestions += 1;
        }
        Progress.value = CurrentQuestions;
    }

    public void goedAntwoord()
    {
        CurrentQuestions += 1;
    }


}
