//docs.unity3d.com/ScriptReference/Input.html
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    //Variables
    private Rigidbody rb;                                   //Create ridgidbody variable to hold reference
    public float speed;                                     //Speed of ball
    private int count;                                      //Holds PickUp count or score
    public Text countText;                                  //Hold reference to UI text component
    public Text winText;                                    //Hold reference to UI text component

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();                     //Reference
        count = 0;                                          //Initialize score
        SetCountText();                                     //Call function to set the count text
        winText.text = "";                                  //Start empty
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // Update just before physics is calculated
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //Returns the value of the virtual axis identified by axisName. -1 - 1 for Keyboard
        float moveVertical = Input.GetAxis("Vertical");     //Returns the value of the virtual axis identified by axisName. -1 - 1 for Keyboard
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);     //Create Vector3 with (x,y,z)
        rb.AddForce(movement * speed);                              //Place Vector3 into AddForce
    }

    void OnTriggerEnter(Collider other)                     //Called when touching a trigger collider
    {
        if (other.gameObject.CompareTag("PickUp"))          //if tag of object is "PickUp"
        {
            other.gameObject.SetActive(false);              //Deactivate game object
            count++;                                        //Increment score
            SetCountText();                                 //Call function to set the count text
        }
        //Destroy(other.gameObject);                         //Destroys object
    }   

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 14)                                    //if the number collected is total
        {
            winText.text = "Got Them All!";                 //Change message
        }
    }
}

