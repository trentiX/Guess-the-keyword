using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.UI;

public class DicreaseAmountOfPlayers : MonoBehaviour
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

        if (amount > 4)
        {
            amount = amount - 2;
            DataHolder.amountOfPlayers = amount;
        }

        if (amount < 5) // decrease boarders of field when thereare less then 5 players
        {
            InputField3.SetActive(false);

            rt.sizeDelta = new Vector2(820, 662);
            rtB.sizeDelta = new Vector2(840, 680);

            rt.position = new Vector2(540, 960);
            rtB.position = new Vector2(540, 960);
        }

        else if (amount < 7) // decrease boarders of field when thereare less then 7 players
        {
            InputField4.SetActive(false);

            rt.sizeDelta = new Vector2(820, 833);
            rtB.sizeDelta = new Vector2(840, 855);

            rt.position = new Vector2(540, 872);
            rtB.position = new Vector2(540, 872);
        }

        AmountOfPlayers.GetComponent<Text>().text = Convert.ToString(amount);
        AmountOfPlayers2.GetComponent<Text>().text = Convert.ToString(amount);
    }

}
