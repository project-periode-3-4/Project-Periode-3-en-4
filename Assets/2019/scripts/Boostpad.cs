using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Boostpad : MonoBehaviour {

    public int force;
    public float X;
    public float Y;
    public float Z;
    public GameObject Ramp;
    public Vector3 Direction;

    // Use this for initialization
    void Start () {
        Ramp = GameObject.FindGameObjectWithTag("Ramp");
    }

    // Update is called once per frame
    void Update() {
        X = Ramp.transform.eulerAngles.x / ( gameObject.transform.eulerAngles.x * 2 );
        Y = Ramp.transform.eulerAngles.y / ( gameObject.transform.eulerAngles.y * 2 );
        Z = Ramp.transform.eulerAngles.z * ( gameObject.transform.localEulerAngles.z * 20);
        Direction = Ramp.transform.TransformDirection(X, Y, Z);   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boostpad") {
            GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Direction * force));
            Debug.Log("Fuck");
        }
    }
}