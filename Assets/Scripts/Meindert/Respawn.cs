using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    Vector3 beginPositie;

    // Use this for initialization
    void Start()
    {
        beginPositie = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "KillZone")
        {
            transform.position = new Vector3(485.8f, 0.6f, 487.8f);
            //transform.position = beginPositie;
            Debug.Log("Ik wil dood");
        }
    }
}
