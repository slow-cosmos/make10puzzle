using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{


    public void StartButton()
    {
        SceneManager.LoadScene("Play");
    }
}
