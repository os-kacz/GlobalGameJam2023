using System.Collections;
using System.Collections.Generic;
using Platformer.Core;
using Platformer.Model;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoundtdownTimer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn;

    public TextMeshProUGUI countdownText;

    void Start()
    {
        TimerOn = true;
    }

    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= 1 * Time.deltaTime;
            }
            else
            {
                TimeLeft = 0;
                TimerOn = false;
                //Application.LoadLevel(Application, loadedlevel);
            }
            updateTimer(TimeLeft);
        }
    }

    void updateTimer(float TimeLeft)
    {
        float minutes = Mathf.FloorToInt(TimeLeft / 60);
        float seconds = Mathf.FloorToInt(TimeLeft % 60);

        countdownText.text = string.Format("{0:00} : {1:00}", minutes, seconds);

    }
}

