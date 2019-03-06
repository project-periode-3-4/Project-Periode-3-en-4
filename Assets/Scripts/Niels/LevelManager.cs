using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LaadLevel(string levelnaam)
    {
        //levelnaam laden
        SceneManager.LoadScene(levelnaam);
    }

    public void StopSpel()
    {
        //spel stoppen
        Application.Quit();
    }
}