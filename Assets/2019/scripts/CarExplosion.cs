using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarExplosion : MonoBehaviour {

	
	void Start () {
        
}
    public GameObject explosion;

    void Update () {

        
        
    }
    void OnCollisionEnter(Collision collision)
    {
        float currentSpeed = gameObject.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().CurrentSpeed;
        Debug.Log(currentSpeed);
        if (currentSpeed > 25)
        {
            GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            //Transform Camera;
            //Camera = gameObject.transform.Find("PlayerCamera");

            gameObject.SetActive(false);
        }

    }

}



//explode function
// -> spawn explosion
// -> get the camera
// -> deactivate player object
// -> activate saved camera


