using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class QuizLoad : MonoBehaviour
{

    public GameObject levelmanager;

    // Use this for initialization
    void Start()
    {
        levelmanager = GameObject.Find("levelmanager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //levelmanager.GetComponent<LevelManager>().LaadLevel("");
			SceneManager.LoadScene("quiz");
        }
    }
}
