using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuziekSpeler : MonoBehaviour
{
    static MuziekSpeler instance = null;

    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);//als er al een nummer afspeelt wordt het niet verwijderd
        }
    }

    void Awake()
    {
        string mute = PlayerPrefs.GetString("Mute");
        if (mute == "true")
        {
            AudioListener.pause = true;//geluid uit
        }
        else
        {
            AudioListener.pause = false;//geluid aan
        }
    }

    void update()
    {
        //AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }
}
