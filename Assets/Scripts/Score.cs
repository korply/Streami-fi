using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int currentScore;
    public Text text;
    GameObject top;
    GameObject down;
    GameObject left;
    GameObject right;

    GameObject topG;
    GameObject downG;
    GameObject leftG;
    GameObject rightG;

    void Start()
    {
        currentScore = 0;
    }

    void Update()
    {
        top = GameObject.Find("Top(Clone)/Perfact");
        down = GameObject.Find("Down(Clone)/Perfact");
        left = GameObject.Find("Left(Clone)/Perfact");
        right = GameObject.Find("Right(Clone)/Perfact");
        topG = GameObject.Find("Top(Clone)/Good");
        downG = GameObject.Find("Down(Clone)/Good");
        leftG = GameObject.Find("Left(Clone)/Good");
        rightG = GameObject.Find("Right(Clone)/Good");

        if (top == true)
        {
            currentScore += 10;
        }
        if (down == true)
        {
            currentScore += 10;
        }
        if (left == true)
        {
            currentScore += 10;
        }
        if (right == true)
        {
            currentScore += 10;
        }
        if (topG == true)
        {
            currentScore += 3;
        }
        if (downG == true)
        {
            currentScore += 3;
        }
        if (leftG == true)
        {
            currentScore += 3;
        }
        if (rightG == true)
        {
            currentScore += 3;
        }
        text.text = currentScore.ToString();
    }
}
