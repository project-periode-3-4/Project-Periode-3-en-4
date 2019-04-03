using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

    private Animator Anim;
    private Rigidbody RigidB;
    private Renderer[] ChildRenderers;
    private GameObject Explosion;
    private float Durability;

    public Material[] exploded;
    public GameObject[] Wheels;

	// Use this for initialization
	void Start () {
        Durability = 100f;
        Anim = GetComponent<Animator>();
        RigidB = GetComponent<Rigidbody>();
        ChildRenderers = GetComponentsInChildren<Renderer>();
        Explosion = transform.Find("Explosion").gameObject;

    }

    private void Update()
    {
        // testding
        print(RigidB.velocity.magnitude + " " + Durability);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer != 9)
        {
            Durability -= RigidB.velocity.magnitude;
            if (Durability <= 0)
            {
                explode();
            }
        }
    }

    private void explode()
    {
        RigidB.mass = 4;
        Explosion.SetActive(true);
        
        for(var j = 0; j < ChildRenderers.Length; j++)
        {
            for (var i = 0; i < ChildRenderers[j].materials.Length; i++)
            {
                ChildRenderers[j].materials = exploded;
            }
        }

        foreach(GameObject Wheel in Wheels)
        {
            Wheel.SetActive(false);
        }
    }
}
