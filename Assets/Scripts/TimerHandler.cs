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
    public bool isEnd;
    public static bool stopTimer;

    ScoreHandler scoreHandler;

    void Start()
    {
        stopTimer = false;
        isEnd = false;
        timer.maxValue = gameTime;
        timer.value = gameTime;

        scoreHandler = GameObject.Find("Score").GetComponent<ScoreHandler>();
    }

    void Update()
    {
        float time = gameTime - Time.timeSinceLevelLoad;

        if (time <= 0.1f)
        {
            timer.value = 0;
            if(isEnd == false)
            {
                EndGame();
            }
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

    void EndGame()
    {
        stopTimer = true; //타이머 멈추기
        gameEndPopup.SetActive(true); //게임 끝 팝업
        MouseHandler.mouseActive = false; //마우스 드래그 못하게
        scoreHandler.SaveMaxScore(); //끝났을 때 게임 저장
        SoundManager.Instance.SfxPlay(2, 0.1f); //효과음

        isEnd = true;

        Debug.Log("게임 끝~");
    }
}
