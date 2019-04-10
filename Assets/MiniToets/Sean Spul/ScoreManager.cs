using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    int score;
    public Text Scoretext;

    void Awake()
    {
        PlayerPrefs.SetInt("Player score", score);
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GoedAntwoord")
        {
            score++;
        }

        if (other.gameObject.tag == "FoutAntwoord")
        {
            score--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Scoretext.text = ("Score: " + score);
        PlayerPrefs.GetInt("Player score");
    }
}
