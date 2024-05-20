using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field2AnimScript : MonoBehaviour
{
    public Transform Field;
    public int x;
    public int y;   
    public int dest;
    private void OnEnable() // play animation on start of the game
    {
        Field.localPosition = new Vector2(x, y);
        Field.LeanMoveLocalX(dest, 0.75f).setEaseOutQuart().delay = 0.15f;
    }
}
