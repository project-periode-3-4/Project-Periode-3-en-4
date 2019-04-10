using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressSystem : MonoBehaviour
{

    [SerializeField] private int Progress;

    public Transform player;
    public Text[] tasks;
    public GameObject[] taskObjets;

    void Update()
    {
        for (int i = 0; i < taskObjets.Length; i++)
        {
            float dis = Vector3.Distance(player.position, taskObjets[i].transform.position);
            print("Distance between the objects is: " + dis);
        } 
    }
    
}
