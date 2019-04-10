using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizScript2 : MonoBehaviour
{

    public Text GoedAntwoordText;
    public Text FoutAntwoordText;
    public GameObject GoedAntwoordGameobject;
    public GameObject FoutAntwoordGameobject;
    public Text Scoretext;
    public GameObject player;

    LevelManager levelmanager;

    int score;

    Vector3 startpos;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        levelmanager = GameObject.FindObjectOfType<LevelManager>();
    }

    void AntwoordGoed(){
            player.transform.position = new Vector3(0f, 0f, 0f);
            GoedAntwoordText.text = ("Goed geantwoord! +1 punt.");
            GoedAntwoordGameobject.SetActive(true);
    }

    void AntwoordFout(){
            FoutAntwoordText.text = ("Fout geantwoord! Je krijgt geen punten.");
            FoutAntwoordGameobject.SetActive(true);        
    }


    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "GoedAntwoord")
            {
                AntwoordGoed();
                Debug.Log("Heel Goed");
                score++;     
            }

        if(col.gameObject.tag == "FoutAntwoord")
            {
                AntwoordFout();
                Debug.Log("Heel Fout");
            }
    }

    void Update()
    {
        Scoretext.text = ("Score: " + score);
    }
}
