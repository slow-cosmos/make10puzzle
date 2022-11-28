﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField]
    Text curScoreText, maxScoreText;

    [SerializeField]
    Text gameEndScoreText;

    public static int curScore = 0;
    public static int maxScore;

    void Start()
    {
        curScore = 0;
    }

    void Update()
    {
        curScoreText.text = curScore.ToString();
        maxScoreText.text = maxScore.ToString();
        gameEndScoreText.text = curScore.ToString();

        if (maxScore < curScore)
        {
            maxScore = curScore;
        }
    }

}
