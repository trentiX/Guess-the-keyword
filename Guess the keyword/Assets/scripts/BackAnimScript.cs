using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackAnimScript : MonoBehaviour
{
    public CanvasGroup backIcon;

    private void OnEnable()
    {
        backIcon.alpha = 0;
        backIcon.LeanAlpha(0.05f, 0.5f).setEaseOutQuart().delay = 0.5f;
    }
}