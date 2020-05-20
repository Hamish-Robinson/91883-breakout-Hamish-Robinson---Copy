//  Name: 
//  Teacher:  CBR or NMK.
//  Description: Makes sure the ball always moves at a consistant speed.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 10;  // Public variable for speed balls moves at.  Set as public so it can be altered via Unity Console
    private Rigidbody rb;  // Variable to store balls rigid body

    // Start is called before the first frame update

    private void Start()
    {
        Invoke("myStart", 1.5f);
    }


    void myStart()
    {
       
        rb = GetComponent<Rigidbody>();  // Get a reference to the players rigidbody

        float moveHorizontal = 1; // Store the initial ball horizontal movement
        float moveVertical = 1; // Store the initial ball veritcal movement

        Vector3 movement = new Vector3(-moveHorizontal, 0, moveVertical); // create a vector3 to store the balls initial movement.
        rb.AddForce(movement); // use the vector to give the ball some force
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // set the balls speed at a constant speed every frame by 
        // normalizing the direction vector (create a vector length of 1) and multiple by speed.
        //rb.velocity = speed * (rb.velocity.normalized);

        
    }
}
