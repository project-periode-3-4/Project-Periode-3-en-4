using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{
    [TextArea]
    public string QuizText = "";

    [SerializeField] private Text questionOne;

    public void Start()
    {
        questionOne.text = QuizText;
    }
}
