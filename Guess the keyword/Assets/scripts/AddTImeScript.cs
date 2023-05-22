using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddTImeScript : MonoBehaviour
{
    public GameObject TimeInButton;
    public GameObject TimeInField;

    public void AddTime()
    {
        float time = Convert.ToInt32(TimeInButton.GetComponent<Text>().text);

        if (time < 25)
        {
            time = time + 5;
            DataHolder.time = time;
            TimeInButton.GetComponent<Text>().text = Convert.ToString(time);
            TimeInField.GetComponent<Text>().text = Convert.ToString(time);
        }
    }

    public void DiscreseTime()
    {
        float time = Convert.ToInt32(TimeInButton.GetComponent<Text>().text);

        if (time > 5)
        {
            time = time - 5;
            DataHolder.time = time;
            TimeInButton.GetComponent<Text>().text = Convert.ToString(time);
            TimeInField.GetComponent<Text>().text = Convert.ToString(time);
        }
    }
}
