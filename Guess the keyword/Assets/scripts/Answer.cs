using System;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    [SerializeField] private InputField field;
    [SerializeField] private Text mainText;
    [SerializeField] private Animator mainTextAnimator;
    private string[] gameCategory;
    private TimerScript timer;
    const string FADEIN = "FadeIn";


    private void Start()
    {
        gameCategory = DataHolder.categoryOfWord;
        Array.Sort(gameCategory); // Ensure the array is sorted for binary search
        timer = FindObjectOfType<TimerScript>(); // Assuming TimerScript is attached to an active GameObject
    }

    public void GiveAnswer()
    {
        string answer = field.text;
        Debug.Log("Answer: " + answer);

        int result = CustomBinarySearch(gameCategory, answer);

        if (result < 0)
        {
            Debug.Log("No matches found");
        }
        else
        {
            Win();
        }
    }

    private int CustomBinarySearch(string[] array, string value)
    {
        int left = 0, right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int comparison = string.Compare(value, array[mid], StringComparison.Ordinal);

            if (comparison == 0)
            {
                return mid;
            }

            if (comparison > 0)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1; // Value not found
    }

    private void Win()
    {
        mainText.text = $"{timer.currTeam} wins!";
        mainTextAnimator.Play(FADEIN);
    }
}