using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageTextScript : MonoBehaviour
{
    public int language;
    public string[] text;
    private Text textLine;

    void Start()
    {
        language = PlayerPrefs.GetInt("language", language); //��������� ����
        textLine = GetComponent<Text>(); //���������� � ����������
        textLine.text = "" + text[language]; //��������� ����� ����� ����� ������������, � ����������� �� ���������� �����
    }
}
