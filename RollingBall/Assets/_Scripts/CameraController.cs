using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    //Variables
    public GameObject player;                                       //Game object reference
    private Vector3 offset;                                         //Holds offset

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;    //Get the offset position of the camera from the player
	}
	
	// LateUpdate is called after all processes are run and updated (after player moves)
	void LateUpdate () {
        transform.position = player.transform.position + offset;    //Move camera to the new offset position
	}
}
