using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField]
    Text curScoreText, maxScoreText;

    public static int curScore = 0;
    public static int maxScore;

    void Start()
    {

    }
    
    void Update()
    {
        curScoreText.text = curScore.ToString();

        if (maxScore < curScore)
        {
            maxScoreText.text = curScoreText.text;
        }
    }

}
