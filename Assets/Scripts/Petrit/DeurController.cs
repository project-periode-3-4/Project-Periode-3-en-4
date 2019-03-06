using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeurController : MonoBehaviour {

    private Animator _animator; 

	// Use this for initialization
	void Start () {
        _animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Opening () {

        print("open");
        _animator.SetBool("IsOpen", true);
        
    }

    public void Closing()
    {
        print("dicht");
        _animator.SetBool("IsOpen", false);
        
    }

}
