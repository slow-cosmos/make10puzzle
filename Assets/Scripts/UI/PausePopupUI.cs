using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePopupUI : MonoBehaviour
{
    [SerializeField]
    GameObject pausePopup;

    public void PauseButton()
    {
        Timer.stopTimer = true;
        pausePopup.SetActive(true);
        MouseHandler.mouseActive = false;
        SoundManager.Instance.SfxPlay(0,0.2f);
        SoundManager.Instance.BgmPause();
    }

    public void PlayButton()
    {
        Timer.stopTimer = false;
        pausePopup.SetActive(false);
        MouseHandler.mouseActive = true;
        SoundManager.Instance.SfxPlay(0,0.2f);
        SoundManager.Instance.BgmPlay();
    }
}
