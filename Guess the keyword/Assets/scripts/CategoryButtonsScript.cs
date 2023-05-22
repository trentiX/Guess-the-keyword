using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class CategoryButtonsScript : MonoBehaviour
{
    public GameObject buttonBack;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public Button startButton;

    public string category = "school";
    

    public void ActiveButton1()
    {
        startButton.interactable = true;

        GameObject[] objArray = { button1 , button2 , button3 , button4 , button5 };

        foreach (GameObject obj in objArray)
        {
            obj.SetActive(false);
        }
        buttonBack.SetActive(true);
        category = buttonBack.name;
        DataHolder.myCategory = category;

        Debug.Log(category);
    }
}
