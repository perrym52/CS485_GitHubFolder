//Tutorial: youtube.com/watch?v=JKoBWBXVvKY
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour {

	//Run when created
	void Awake () {
		GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");     //Look for objects Tagged Music and place in array
        if(objs.Length > 2)                                                 //Destroy 2nd instances of this object
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
	
}
