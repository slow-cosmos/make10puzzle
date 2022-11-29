using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePopupHandler : MonoBehaviour
{
    [SerializeField]
    GameObject pausePopup;

    public void PauseButton()
    {
        TimerHandler.stopTimer = true;
        pausePopup.SetActive(true);
        MouseHandler.mouseActive = false;
        SoundManager.Instance.SfxPlay(0,0.2f);
    }

    public void PlayButton()
    {
        TimerHandler.stopTimer = false;
        pausePopup.SetActive(false);
        MouseHandler.mouseActive = true;
        SoundManager.Instance.SfxPlay(0,0.2f);
    }
}
