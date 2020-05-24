using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class YouWinButton : MonoBehaviour
{
    public void changemenuscene()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);


    }
}
