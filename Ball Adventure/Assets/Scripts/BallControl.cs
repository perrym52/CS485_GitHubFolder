//Audio Tutorial: youtube.com/watch?v=Yb3isH6j-iU
//Music Author: gasguy(Newgrounds)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallControl : MonoBehaviour {
    //Variables
    private Rigidbody rb;                                                       //Create ridgidbody variable to hold reference
    public float speed;                                                         //Speed of ball
    public AudioSource portalsound;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();                                         //Create the rigidbody component   
    }

    // Update is called once per frame
    void Update () {

    }
    //Called when touching a trigger collider
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))                                //If tag of object is "Wall", Call gotoNextScene();
        {
            restartScene();
        }
        if (other.gameObject.CompareTag("Portal"))                              //If tag of object is "Portal", Call gotoNextScene();
        {
            gotoNextScene();
        }
    }

    // FixedUpdate is called after calculations
    void FixedUpdate()
    {
        float moveHorizontal = Input.acceleration.x;                            //Set moveHorizontal based on phone rotation input
        float moveVertical = Input.acceleration.y;                              //Set moveVertical based on phone rotation input
        float keyMoveHorizontal = Input.GetAxis("Horizontal");                   //PC Debug
        float keyMoveVertical = Input.GetAxis("Vertical");                       //PC Debug

        Vector3 movement = new Vector3(moveHorizontal + keyMoveHorizontal, moveVertical + keyMoveVertical, 0.0f);     //Create movement with Vector3 (x,y,z)
        rb.AddForce(movement * speed);                                          //Add force to the object
        
    }
    //Restart the scene
    void restartScene()
    {
        Scene scene = SceneManager.GetActiveScene();                            //Get the current active scene
        SceneManager.LoadScene("" + scene.name);                                //Load the scene
    }
    //Load next scene if it exists
    void gotoNextScene()
    {
        //portalsound.Play();
        Scene scene = SceneManager.GetActiveScene();                            //Get the current active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   //Load the scene after it
    }
}