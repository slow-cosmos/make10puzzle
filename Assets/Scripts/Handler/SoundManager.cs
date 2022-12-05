using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    AudioSource bgmAudioSource;

    [SerializeField]
    AudioSource sfxAudioSource;

    [SerializeField]
    AudioClip bgm;
    [SerializeField]
    AudioClip[] sfx;

    [SerializeField]
    float bgmVolume;

    public static int activeSound=1;

    private static SoundManager instance;
    public static SoundManager Instance
    {
        get
        {
            if (instance == null) instance = new SoundManager();
            return instance;
        }
    }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        if (PlayerPrefs.HasKey("ActiveSound"))
        {
            activeSound = PlayerPrefs.GetInt("ActiveSound");
        }
    }

    public void BgmPlay()
    {
        if(activeSound == 1)
        {
            bgmAudioSource.clip = bgm;
            bgmAudioSource.loop = true;
            bgmAudioSource.volume = bgmVolume;
            bgmAudioSource.Play();
        }
    }

    public void BgmStop()
    {
        bgmAudioSource.Stop();
    }

    public void BgmPause()
    {
        bgmAudioSource.Pause();
    }

    public void SfxPlay(int index, float volume) // 0은 클릭, 1은 블록 터뜨리기, 2는 게임 끝
    {
        if(activeSound == 1)
        {
            sfxAudioSource.volume = volume;
            sfxAudioSource.PlayOneShot(sfx[index]);
        }
    }
}
