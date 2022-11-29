using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Play");
        SoundManager.Instance.SfxPlay(0,0.2f);
    }

    public void LobbyButton()
    {
        SceneManager.LoadScene("Lobby");
        SoundManager.Instance.SfxPlay(0,0.2f);
    }
}
