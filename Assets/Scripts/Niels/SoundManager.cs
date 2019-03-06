using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Toggle checkbox;
    public Slider volumebar;

    void Start()
    {

        volumebar = GameObject.FindObjectOfType<Slider>();

        checkbox = GameObject.FindObjectOfType<Toggle>();

        if (PlayerPrefs.GetString("Mute") == "true")
        {
            checkbox.isOn = false;//als mute aan is gaat de checkbox uit
        }
        else if (PlayerPrefs.GetString("Mute") == "false")
        {
            checkbox.isOn = true;//als de mute niet aan is gaat de checkbox aan
        }
    }

    public void Update()
    {
        volumebar.value = PlayerPrefs.GetFloat("volume");
    }

    public void Mute()
    {

        if (checkbox.isOn)
        {
            PlayerPrefs.SetString("Mute", "false");
            AudioListener.pause = false;
        }
        else
        {
            PlayerPrefs.SetString("Mute", "true");
            AudioListener.pause = true;
        }
    }

    public void SetVolume(float vol)
    {
        //PlayerPrefs.SetFloat("volume", vol);
        PlayerPrefs.SetFloat("volume", vol);
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
        //Debug.Log(PlayerPrefs.GetFloat("volume"));
    }
}
