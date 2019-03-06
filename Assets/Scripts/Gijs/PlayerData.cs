using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData{

    public float level;
    public float progress;

    public PlayerData (Player player)
    {
        level = player.level;
        progress = player.progress;
    }
}
