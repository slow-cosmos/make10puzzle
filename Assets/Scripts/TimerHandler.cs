using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerHandler : MonoBehaviour
{
    [SerializeField]
    Slider timer;

    [SerializeField]
    GameObject gameEndPopup;

    public float gameTime;

    public static bool stopTimer;

    void Start()
    {
        stopTimer = false;
        timer.maxValue = gameTime;
        timer.value = gameTime;
    }

    void Update()
    {
        float time = gameTime - Time.timeSinceLevelLoad;

        if (time <= 0.1f)
        {
            timer.value = 0;
            stopTimer = true;
            gameEndPopup.SetActive(true);
            MouseHandler.mouseActive = false;
        }

        if(stopTimer==false)
        {
            Time.timeScale = 1;
            timer.value = time;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}
