using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

    private Animator _animator = null;

	// Use this for initialization
	void Start () {
        _animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        _animator.SetBool("IsOpen", true);
    }

    public void OnTriggerExit(Collider other)
    {
        _animator.SetBool("IsOpen", false);
    }
}
