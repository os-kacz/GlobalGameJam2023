using System.Collections;
using System.Collections.Generic;
using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static Platformer.Core.Simulation;
using Platformer.Gameplay;

public class CoundtdownTimer : MonoBehaviour
{
    public float TimeLeft = 120;
    public bool TimerOn;

    public TextMeshProUGUI countdownText;
    PlatformerModel model = Simulation.GetModel<PlatformerModel>();

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
                
                Schedule<PlayerDeath>();
                TimeLeft = 120;
            }
        }
        updateTimer(TimeLeft);
    }


    void updateTimer(float TimeLeft)
    {
        float minutes = Mathf.FloorToInt(TimeLeft / 60);
        float seconds = Mathf.FloorToInt(TimeLeft % 60);

        countdownText.text = string.Format("{0:00} : {1:00}", minutes, seconds);

    }
}


