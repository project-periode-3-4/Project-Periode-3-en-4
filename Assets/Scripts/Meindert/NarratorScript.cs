using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarratorScript : MonoBehaviour
{

    public bool enter;
    public AudioClip Laser_Shoot52;
    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        enter = false;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enter = true;
            source.PlayOneShot(Laser_Shoot52);
            Debug.Log("Entered");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enter = false;
            Debug.Log("Exited");
        }
    }
}
