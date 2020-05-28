using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BrickDisappear : MonoBehaviour
{
    // Start is called before the first frame update
    GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Brick")
        {
            other.gameObject.SetActive(false);
            gameManager.BrickCollision();

        } else if (other.gameObject.tag == "BottomWall")
        {
            print("Collision");
            SceneManager.LoadScene("GameOver",LoadSceneMode.Single);
            
        }
    }
}
