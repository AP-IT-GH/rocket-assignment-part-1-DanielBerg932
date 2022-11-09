using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public string message = "";
    public string lvl;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "level trigger")
        {
            message = "entered";
            SceneManager.LoadScene(lvl);
        }



    }
}
