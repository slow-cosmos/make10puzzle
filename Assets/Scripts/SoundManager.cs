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
    }

    public void BgmPlay()
    {
        bgmAudioSource.clip = bgm;
        bgmAudioSource.loop = true;
        bgmAudioSource.volume = 0.1f;
        bgmAudioSource.Play();
    }

    public void SfxPlay(int index, float volume) // 0은 클릭, 1은 블록 터뜨리기, 2는 게임 끝
    {
        sfxAudioSource.volume = volume;
        sfxAudioSource.PlayOneShot(sfx[index]);
    }


}
