using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Unity.VisualScripting.Icons;

public class InputFieldTextScript : MonoBehaviour
{
    [SerializeField] InputField field;
    public int fieldNum;

    public void OnEditEnd()
    {
        switch (fieldNum)
        {
            case 0:
                DataHolder.firstTeamName = field.text;
                Debug.Log("Firts team name: " + field.text); // тест записанного текста
                break;
            case 1:
                DataHolder.secTeamName = field.text;
                Debug.Log("Second team name: " + field.text); // тест записанного текста
                break;
            case 2:
                DataHolder.thirdTeamName = field.text;
                Debug.Log("Third team name: " + field.text); // тест записанного текста
                break;
            case 3:
                DataHolder.fourthTeamName = field.text;
                Debug.Log("Fourth team name: " + field.text); // тест записанного текста
                break;
            default:
                break;
        }

    }
}
