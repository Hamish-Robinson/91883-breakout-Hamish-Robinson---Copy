//  Name:
//  Teacher:  CBR or NMK
//  Description:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject brick;


    // Start is called before the first frame update
    void Start()
    {
        // start y for loop here
        for (float z = 0; z < 5; z = z + 1)
        {
            float zlocation = ((float)z * 2.5f) + 4f;
            //
            for (float x = 0; x < 5; x = x + 1)

            {
                float xlocation = ((float)x * 2.5f) - 5f;
                Instantiate(brick, new Vector3(xlocation, 0.2f, zlocation), brick.transform.rotation);
            }

        }
        /* {
             float xlocation = ((float)x * 2.5f) + -5.3f;
             Instantiate(brick, new Vector3(xlocation, 0.5f, 9), brick.transform.rotation);
         }*/

        // finish y for loop here
    }
    // Update is called once per frame
    void Update()
    {

    }
}
