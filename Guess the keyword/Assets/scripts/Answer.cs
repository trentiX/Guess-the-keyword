using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    [SerializeField] InputField field;

    private String[] gameCategory;
    private String answer;
    private TimerScript timer;

    private void Start()
    {
        gameCategory = DataHolder.categoryOfWord;
        Debug.Log(gameCategory);
    }

    public int CheckTheWord(String answer)
    {
        int l = 0, r = gameCategory.Length - 1; 
  
        // Loop to implement Binary Search 
        while (l <= r) { 
  
            // Calculatiing mid 
            int m = l + (r - l) / 2; 
            Debug.Log("m:" + m);
            Debug.Log(gameCategory[m]);
            int res = answer.CompareTo(gameCategory[m]); 
            Debug.Log("res:" + res);
            // Check if x is present at mid 
            if (res == 0)
            {
                return m;
            }
            
            // If x greater, ignore left half 
            if (res > 0)
            {
                l = m + 1;
                Debug.Log("l:" + l);
            }
            // If x is smaller, ignore right half 
            else
            {
                r = m - 1; 
                Debug.Log("r:" + r);
            }
        }

        return -1;
    }

    public void GiveAnswer()
    {
        answer = field.text;
        Debug.Log("answer: " + answer);
        
        int result = CheckTheWord(answer); 

        if (result == -1) 
            Debug.Log("Zero mathces");
        else
            win();
    }
    private void win()
    {
        Debug.Log("some team" + "wins!");
    }
}
