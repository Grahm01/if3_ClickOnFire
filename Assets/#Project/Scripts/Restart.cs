using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : SceneChanger
{
    public Generator manager;

    public void Change(string sceneName)
    {
        if (manager.score >= 30)
        {
            Debug.Log("Gagné!");

            SceneManager.LoadScene(sceneName);


        }

    }

}