using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public Transform player;
    public Transform interactable;
    public float range;

    public bool interact;
    public bool interactionIsActive;

    public GameObject popUp;

	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        popUp.SetActive(false);
        interact = false;
        interactionIsActive = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Vector3.Distance(transform.position, interactable.position) < range)
        {
            print("Interact = true");
            interact = true;
        } else
        {
            print("Interact = false");
            interact = false;
        }

        InteractWithObject();
	}

    public void InteractWithObject()
    {
        if (interact == true && !interactionIsActive)
        {
            if (Input.GetKeyDown("space"))
            {
                print("YEEEEEEEEET");
                popUp.SetActive(true);
                interactionIsActive = true;
            }
        }
    }

    public void QuitOnderwijsOnline()
    {
        if(interact == true && interactionIsActive)
        {
            popUp.SetActive(false);
            interactionIsActive = false;
        }
    }
}
