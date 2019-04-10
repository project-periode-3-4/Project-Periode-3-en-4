using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerSean : MonoBehaviour
{

    public void Laadlevel(string levelnaam)
    {
        //Hiermee kan je een specifieke scene laden
        SceneManager.LoadScene(levelnaam);
    }

    public void LaadVolgende()
    {
        //Hiermee laad je het volgende level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StopSpel()
    {
        //Hiermee stop je het spel
        Application.Quit();
    }
}
