using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerScript : MonoBehaviour 
{
    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void ChangeScene(string sceneName) // changing scene
    {
        SceneManager.LoadScene(sceneName);
    }
}
