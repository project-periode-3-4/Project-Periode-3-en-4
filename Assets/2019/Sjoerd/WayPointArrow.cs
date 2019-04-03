using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointArrow : MonoBehaviour {

    public Transform[] checkpoints;

    private Vector3 Checkpoint;
    private int CheckpointNr;

	void Start () {
        CheckpointNr = 0;
        Checkpoint = new Vector3(checkpoints[0].position.x, checkpoints[0].position.y + 3, checkpoints[0].position.z);


    }
	
	void FixedUpdate () {
        transform.LookAt(Checkpoint);
        transform.rotation = transform.rotation * Quaternion.Euler(90, 0, 0);

        if (Input.GetKeyDown(KeyCode.N))
        {
            NextCheckpoint(1);
        }
    }



    public void NextCheckpoint(int nr)
    {
        CheckpointNr = nr;
        Checkpoint = new Vector3(checkpoints[CheckpointNr].position.x, checkpoints[CheckpointNr].position.y, checkpoints[CheckpointNr].position.z);
    }
}
