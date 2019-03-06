using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionQuiz : MonoBehaviour {

    public string currentawnser;
    public string[] awnser;
    public string[] questions;
    public string[] awnserA;
    public string[] awnserB;
    public string[] awnserC;
    public string[] awnserD;
    public int question;
    public Text currentquestion;
    public Text AwnserA;
    public Text AwnserB;
    public Text AwnserC;
    public Text AwnserD;
    public int points;
    public Text point;
    public Text currentQuestionNumber;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentQuestionNumber.text = "Question: "+ question;
        point.text = "Points: " + points;
        currentquestion.text = questions[question];
        AwnserA.text = awnserA[question];
        AwnserB.text = awnserB[question];
        AwnserC.text = awnserC[question];
        AwnserD.text = awnserD[question];
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(currentawnser == awnser[question])
            {
                question++;
                points++;
                print("GOOD OL BOI");

            }
            else
            {
                question++;
                print("BAD OL BOI");
            }
        }
	}
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "ButtonA")
        {
            print("A");
            currentawnser = awnserA[question];
        }
        if (collision.gameObject.tag == "ButtonB")
        {
            print("B");
            currentawnser = awnserB[question];
        }
        if (collision.gameObject.tag == "ButtonC")
        {
            print("C");
            currentawnser = awnserC[question];
        }
        if (collision.gameObject.tag == "ButtonD")
        {
            print("D");
            currentawnser = awnserD[question];
        }
    }
}
