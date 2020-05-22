//  Name: 
//  Teacher:  CBR or NMK.
//  Description: Makes sure the ball always moves at a consistant speed.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    private float speed = 10;  // Public variable for speed balls moves at.  Set as public so it can be altered via Unity Console
    private Rigidbody rb;  // Variable to store balls rigid body
    private float brickcount = 30;
    //public void changemenuscene()
    // Start is called before the first frame update

    private void Start()
    {
        rb = GetComponent<Rigidbody>();  // Get a reference to the players rigidbody
        Invoke("myStart", 1.5f);
    }


    void myStart()
    {
        print("pancake");
        

        float moveHorizontal = 1; // Store the initial ball horizontal movement
        float moveVertical = 1; // Store the initial ball veritcal movement

        Vector3 movement = new Vector3(-moveHorizontal, 0, moveVertical); // create a vector3 to store the balls initial movement.
        rb.AddForce(movement); // use the vector to give the ball some force

        // void OnCollisionEnter(Collision other)
        {
            //  if (other.gameObject.tag == "Brick")
            {
                //     brickcount = brickcount - 1;
            }
            // if (brickcount <= 0)
            {
                //    SceneManager.LoadScene("YouWin", LoadSceneMode.Single);
            }
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = speed * (rb.velocity.normalized);
        // set the balls speed at a constant speed every frame by 
        // normalizing the direction vector (create a vector length of 1) and multiple by speed.
    }

}





