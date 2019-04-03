using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostpadVincent : MonoBehaviour {

	//init vars
	[SerializeField] private float multiplier = 1f;
	private float force = 10000f;

	void OnTriggerStay(Collider col){
		//Ignore if not colliding with player
		if(col.transform.root.tag != "Player" ) return;

		//get rigidbody of player
		Rigidbody RbCar = col.transform.root.gameObject.GetComponent<Rigidbody>();

		//adding force to the car relative from the boostpad
		RbCar.AddForce(transform.eulerAngles + transform.forward * force * multiplier);
	}
}