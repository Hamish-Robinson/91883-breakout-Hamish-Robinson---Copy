//  Name:
//  Teacher:  CBR or NMK
//  Description:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public GameObject brick;
    private float brickcount = 30;
    private int winCount;


    // Start is called before the first frame update
    void Start()
    {
        // start y for loop here
        for (float z = 0; z < 6; z++)
        {
            float zlocation = ((float)z * 2.5f) + 4f;
            for (float x = 0; x < 5; x = x + 1)

            {
                float xlocation = ((float)x * 2.5f) - 5f;
                Instantiate(brick, new Vector3(xlocation, 0.2f, zlocation), brick.transform.rotation);
            }
        }
        score = 0;
       

    }

   
    public void BrickCollision()
    {
        print(brickcount);
       
            brickcount = brickcount - 1;
            score = score + 1;
            scoreText.text = "score:" + score.ToString();
        
        if (brickcount <= 0)
        {
            winCount = winCount + 1;
            if (winCount <= 2)
            {
                SceneManager.LoadScene("YouWin", LoadSceneMode.Single);
            }
            else
            {
                SceneManager.LoadScene("God", LoadSceneMode.Single);
            }

        }
       

    }
   
}




   

        



    /* {
         float xlocation = ((float)x * 2.5f) + -5.3f;
         Instantiate(brick, new Vector3(xlocation, 0.5f, 9), brick.transform.rotation);
     }*/

    // finish y for loop here

// Update is called once per frame

