using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerScript : MonoBehaviour 
{ 
    public void ChangeScene(string sceneName) // changing scene
    {
        SceneManager.LoadScene(sceneName);
    }
}
