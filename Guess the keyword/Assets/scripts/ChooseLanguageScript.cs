using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLanguageScript : MonoBehaviour
{
    public int language;

    void Start()
    {
        language = PlayerPrefs.GetInt("language", language);
    }

    public void RussianLanguage()
    {
        language = 0;
        DataHolder.language = language;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene("Game");
    }

    public void EnglishLanguage()
    {
        language = 1;
        DataHolder.language = language;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene("Game");
    }
}
