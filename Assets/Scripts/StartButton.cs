using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void changemenuscene()
    {
        SceneManager.LoadScene("EnterName", LoadSceneMode.Single);


    }
}


   
