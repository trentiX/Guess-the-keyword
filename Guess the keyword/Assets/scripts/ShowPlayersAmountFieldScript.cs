using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;

public class ShowPlayersAmountFieldScript : MonoBehaviour
{
    public Transform Field;
    public GameObject blackImage;
    public CanvasGroup BlackImage;

    private void OnEnable()
    {
        BlackImage.alpha = 0;
        BlackImage.LeanAlpha(1, 0.5f);

        Field.localPosition = new Vector2(0, -1462);
        Field.LeanMoveLocalY(0, 0.75f).setEaseOutQuart().delay = 0.1f;
    }
    public void CloseDialog()
    {
        BlackImage.LeanAlpha(0, 0.5f);
        Field.LeanMoveLocalY(-1462, 0.5f).setEaseOutQuart()
            .setOnComplete(OnComplete);
    }
    void OnComplete()
    {
        gameObject.SetActive(false);
        blackImage.SetActive(false);
    }
}
