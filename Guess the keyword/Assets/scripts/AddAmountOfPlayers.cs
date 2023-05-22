using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class AddAmountOfPlayers : MonoBehaviour
{
    public GameObject AmountOfPlayers;
    public GameObject AmountOfPlayers2;
    public GameObject InputField3;
    public GameObject InputField4;
    public GameObject ChooseAmountOfPlayersField;
    public GameObject ChooseAmountOfPlayersFieldBack;
    public void OnButtonClick()
    {
        int amount = Convert.ToInt32(AmountOfPlayers.GetComponent<Text>().text);
        RectTransform rt = ChooseAmountOfPlayersField.GetComponent<RectTransform>();
        RectTransform rtB = ChooseAmountOfPlayersFieldBack.GetComponent<RectTransform>();

        if (amount < 8)
        {
            amount = amount + 2;
            DataHolder.amountOfPlayers = amount;
        }
        if (amount > 7)
        {
            InputField4.SetActive(true);

            rt.sizeDelta = new Vector2(820, 1027);
            rtB.sizeDelta = new Vector2(840, 1048);
            
            rt.position = new Vector2(540, 778);
            rtB.position = new Vector2(540, 778);
        }

        else if (amount > 5)
        {
            InputField3.SetActive(true);

            rt.sizeDelta = new Vector2(820, 833);
            rtB.sizeDelta = new Vector2(840, 855);

            rt.position = new Vector2(540, 872);
            rtB.position = new Vector2(540, 872);
        }

        AmountOfPlayers.GetComponent<Text>().text = Convert.ToString(amount);
        AmountOfPlayers2.GetComponent<Text>().text = Convert.ToString(amount);
    }
}
