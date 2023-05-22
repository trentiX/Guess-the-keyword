using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    public Text teamMoveText;
    public AudioSource ring;

    private float timeStart = DataHolder.time;
    private int language = DataHolder.language;
    private int teamMove = 0;


    void Start()
    {
        timerText.text = timeStart.ToString();
    }

    private void Update()
    {
        TimerOn();

        switch (DataHolder.amountOfPlayers)
        {
            case 4:
                if (teamMove == 0)
                {
                    TeamMove(DataHolder.firstTeamName);
                }
                else if (teamMove == 1)
                {
                    TeamMove(DataHolder.secTeamName);
                }
                break;
            case 6:
                if (teamMove == 0)
                {
                    TeamMove(DataHolder.firstTeamName);
                }
                else if (teamMove == 1)
                {
                    TeamMove(DataHolder.secTeamName);
                }
                else if (teamMove == 2)
                {
                    TeamMove(DataHolder.thirdTeamName);
                }
                break;
            case 8:
                if (teamMove == 0)
                {
                    TeamMove(DataHolder.firstTeamName);
                }
                else if (teamMove == 1)
                {
                    TeamMove(DataHolder.secTeamName);
                }
                else if (teamMove == 2)
                {
                    TeamMove(DataHolder.thirdTeamName);
                }
                else if (teamMove == 3)
                {
                    TeamMove(DataHolder.fourthTeamName);
                }
                break;
        }
    }
    private void TeamMove(string teamName)
    {
        if (language == 1)
        {
            teamMoveText.text = $"It's {teamName}'s turn to guess the word";
        }
        else if (language == 0)
        {
            teamMoveText.text = $"Сейчас очередь {teamName} отгадывать слово";
        }

    }
    private void TimerOn()
    {
        timeStart -= Time.deltaTime;
        timerText.text = Mathf.Round(timeStart).ToString();
            
        if (timeStart < 1)
        {
            ring.Play();

            switch (DataHolder.amountOfPlayers)
            {
                case 4:
                    if (teamMove == 0)
                    {
                        teamMove++;
                        break;
                    }
                    else if (teamMove == 1)
                    {
                        teamMove--;
                    }
                    break;
                case 6:
                    if (teamMove == 0)
                    {
                        teamMove++;
                        break;
                    }
                    else if (teamMove == 1)
                    {
                        teamMove++;
                        break;
                    }
                    else if (teamMove == 2)
                    {
                        teamMove = 0;
                    }
                    break;
                case 8:
                    if (teamMove == 0)
                    {
                        teamMove++;
                        break;
                    }
                    else if (teamMove == 1)
                    {
                        teamMove++;
                        break;
                    }
                    else if (teamMove == 2)
                    {
                        teamMove++;
                        break;
                    }
                    else if (teamMove == 3)
                    {
                        teamMove = 0;
                    }
                    break;

            }          
            timeStart = DataHolder.time;
            TimerOn();
        }
    }

}