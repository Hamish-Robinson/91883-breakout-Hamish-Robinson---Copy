//  Name:
//  Teacher:  CBR or NMK
//  Description:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float speed = 8;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //Use the code below to control the paddle(player).
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal * .2f + transform.position.x, transform.position.y, transform.position.z);
        transform.position = movement;
        
    }



    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // reads inout of arrow keys <  and >
        float newLocation = moveHorizontal * .2f + transform.position.x;  // based on input calculated new location (the number is the speed it moves at)
        if (newLocation > -4.3 && newLocation < 4.3) 
        {
            Vector3 movement = new Vector3(newLocation, transform.position.y, transform.position.z);
            transform.position = movement;
        }

        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        // Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        //rb.AddForce(movement * speed);

       /* if transform.position.x = > 7.5{ }

        {

        }
*/

    }




}





   




