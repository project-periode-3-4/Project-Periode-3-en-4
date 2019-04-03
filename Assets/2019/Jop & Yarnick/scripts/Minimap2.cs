using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap2 : MonoBehaviour {

    //init vars
    private GameObject car;

    void Start()
    {
        //get car
        car = transform.parent.gameObject;
    }

    void LateUpdate()
    {
        //move MinimapCamera and playerArrow above player without rotation
        transform.position = new Vector3(car.transform.position.x, 250f, car.transform.position.z);
        transform.eulerAngles = new Vector3(90f, car.transform.eulerAngles.y, 0f);
    }
}
