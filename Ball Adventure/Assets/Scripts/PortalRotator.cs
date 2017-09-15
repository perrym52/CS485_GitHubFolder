using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalRotator : MonoBehaviour {
    // Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 200, 0) * Time.deltaTime);     //Rotate axis by delta time
    }
    
}
