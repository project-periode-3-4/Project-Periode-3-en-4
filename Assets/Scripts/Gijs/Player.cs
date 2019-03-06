using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public float level = 1;
    public float progress = 0;

    public Text LevelUI;
    public Text ProgressUI;

    public void SavePlayer ()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer ()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        level = data.level;
        progress = data.progress;
    }

    public void LevelUp ()
    {
        level++;
    }
    public void LevelDown()
    {
        level--;
    }
    public void ProgressUp()
    {
        progress++;
    }
    public void ProgressDown()
    {
        progress--;
    }

    private void Update()
    {
        LevelUI.text = level.ToString();
        ProgressUI.text = progress.ToString();
    }
}
