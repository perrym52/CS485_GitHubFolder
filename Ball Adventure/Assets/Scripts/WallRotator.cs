using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRotator : MonoBehaviour {
    //Variables
    public int rotateSpeed;
    public bool reverseRotate;
    int reverser = 1;

    // Update is called once per frame
	void Update () {
        if (reverseRotate == true)
        {
            reverser = -1;
        }
        transform.Rotate(new Vector3(0f, 0f, rotateSpeed * reverser) * Time.deltaTime);     //Rotate axis by delta time
    }
    
}
