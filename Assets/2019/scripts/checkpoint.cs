using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour {


	private Vector3 currentCheckpoint;
	private Quaternion currentRotation;
	private Rigidbody rb; 	
	private Vector3 startPos;
    public bool dirUp = false;



    //private int axis = 0;




    IEnumerator respawnTimer(){
		yield return new WaitForSeconds (2);
		rb.isKinematic = true;
		transform.position = currentCheckpoint;
		transform.rotation = currentRotation;
		yield return new WaitForSeconds (2);
		rb.isKinematic = false;
	}

	// Use this for initialization
	void Start () {
		currentCheckpoint = transform.position;
		currentRotation = transform.rotation;
		rb = GetComponent<Rigidbody> ();

	}

	// Update is called once per frame
	void Update () {
		/*if (Input.GetAxisRaw ("c") != axis) {

			axis = 1;
			Debug.Log ("he");

		} else {
			axis = 0;
			Debug.Log ("hse");
		}*/

		if (Input.GetKey (KeyCode.R)) {
			StartCoroutine (respawnTimer ());
		}

        if (GameObject.Find("Cube OD").GetComponent<EPIC>().dirUpRe)
        {
            dirUp = false;
            Debug.Log("secret2");
        }


    }

	void OnTriggerEnter (Collider col)
	{
		if(col.gameObject.name == "Checkpoint1")
		{
			currentCheckpoint =  GameObject.Find("Checkpoint1").transform.position;
			currentRotation = Quaternion.Euler (0, 81.48f, 0);
		}

		if(col.gameObject.name == "Checkpoint2")
		{
			currentCheckpoint =  GameObject.Find("Checkpoint2").transform.position;
			currentRotation = Quaternion.Euler (0, 54.531f, 0);
		}

		if(col.gameObject.name == "Checkpoint3")
		{
			currentCheckpoint = GameObject.Find("Checkpoint3").transform.position;
			currentRotation = Quaternion.Euler (0, -80, 0);
		}

		if(col.gameObject.name == "Checkpoint4")
		{
			currentCheckpoint = GameObject.Find("Checkpoint4").transform.position;
			currentRotation = Quaternion.Euler (0, -20, 0);
		}

		if(col.gameObject.name == "Checkpoint5")
		{
			currentCheckpoint = GameObject.Find("Checkpoint5").transform.position;
			currentRotation = Quaternion.Euler (0, 70, 0);
		}

		if(col.gameObject.name == "Checkpoint6")
		{
			currentCheckpoint = GameObject.Find("Checkpoint6").transform.position;
			currentRotation = Quaternion.Euler (0, 40, 0);
		}

		if(col.gameObject.name == "Checkpoint7")
		{
			currentCheckpoint = GameObject.Find("Checkpoint7").transform.position;
			currentRotation = Quaternion.Euler (0, 10, 0);
		}

		if(col.gameObject.name == "Checkpoint8")
		{
			currentCheckpoint = GameObject.Find("Checkpoint8").transform.position;
			currentRotation = Quaternion.Euler (0, -70, 0);
		}

		if(col.gameObject.name == "Checkpoint9")
		{
			currentCheckpoint = GameObject.Find("Checkpoint9").transform.position;
			currentRotation = Quaternion.Euler (0, -150, 0);
		}

		if(col.gameObject.name == "Checkpoint10")
		{
			currentCheckpoint = GameObject.Find("Checkpoint10").transform.position;
			currentRotation = Quaternion.Euler (0, -200, 0);
		}

		if(col.gameObject.name == "Checkpoint11")
		{
			currentCheckpoint = GameObject.Find("Checkpoint11").transform.position;
			currentRotation = Quaternion.Euler (0, 50, 0);
		}

		if(col.gameObject.name == "Checkpoint12")
		{
			currentCheckpoint = GameObject.Find("Checkpoint12").transform.position;
			currentRotation = Quaternion.Euler (0, 40, 0);
		}

		if(col.gameObject.name == "Checkpoint13")
		{
			currentCheckpoint = GameObject.Find("Checkpoint13").transform.position;
			currentRotation = Quaternion.Euler (0, 0, 0);
		}

        if (col.gameObject.name == "Checkpoint14")
        {
            currentCheckpoint = GameObject.Find("Checkpoint14").transform.position;
            currentRotation = Quaternion.Euler(0, 0, 0);
        }

        if (col.gameObject.name == "Checkpoint15")
		{
			currentCheckpoint = GameObject.Find("Checkpoint15").transform.position;
			currentRotation = Quaternion.Euler (0, 0, 0);
		}

		if(col.gameObject.name == "Checkpoint16")
		{
			currentCheckpoint = GameObject.Find("Checkpoint16").transform.position;
			currentRotation = Quaternion.Euler (0, 180, 0);
		}

		if(col.gameObject.name == "Checkpoint17")
		{
			currentCheckpoint = GameObject.Find("Checkpoint17").transform.position;
			currentRotation = Quaternion.Euler (0, -90, 0);
		}

		if(col.gameObject.name == "Checkpoint18")
		{
			currentCheckpoint = GameObject.Find("Checkpoint18").transform.position;
			currentRotation = Quaternion.Euler (0, -90, 0);
		}

		if(col.gameObject.name == "Checkpoint19")
		{
			currentCheckpoint = GameObject.Find("Checkpoint19").transform.position;
			currentRotation = Quaternion.Euler (0, 180, 0);
		}

		if(col.gameObject.name == "Checkpoint20")
		{
			currentCheckpoint = GameObject.Find("Checkpoint20").transform.position;
			currentRotation = Quaternion.Euler (0, 0, 0);
		}

		if(col.gameObject.name == "CheckpointSecret")
		{
			transform.position = new Vector3 (882.5f, 31f, 1100f);
			transform.rotation = Quaternion.Euler (0, 0, 0);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            dirUp = true;
            Debug.Log ("secret");
		}



	}
}