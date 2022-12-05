using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundUI : MonoBehaviour
{
    [SerializeField]
    Sprite soundOn, soundOff;

    [SerializeField]
    Image img;

    public void Start()
    {
        if(SoundManager.activeSound == 1)
        {
            img.sprite = soundOn;
        }
        else if(SoundManager.activeSound == 0)
        {
            img.sprite = soundOff;
        }
    }

    public void SoundButtonClick()
    {
        if(SoundManager.activeSound == 1)
        {
            SoundManager.activeSound = 0;
            //SoundManager.Instance.BgmPause();

            img.sprite = soundOff;

            PlayerPrefs.SetInt("ActiveSound", 0);
            PlayerPrefs.Save();
        }
        else if(SoundManager.activeSound == 0)
        {
            SoundManager.activeSound = 1;
            //SoundManager.Instance.BgmPlay();

            img.sprite = soundOn;

            PlayerPrefs.SetInt("ActiveSound", 1);
            PlayerPrefs.Save();
        }
    }
}
