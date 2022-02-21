using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;
    private int Perfactscore = 100;
    private int Goodscore = 50;
    public int currentScore;
    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multplierThresholds;
    public Text scoreText;
    public Text multiText;
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
        instance = this;
        scoreText.text = "Score: 0";
        currentMultiplier = 1;
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

        // if (Input.anyKeyDown)
        // {
        //     if (top == true)
        //     {
        //         Perfactscore;
        //         currentMultiplier++;
        //     }
        //     else if (down == true)
        //     {
        //         Perfactscore;
        //         currentMultiplier++;
        //     }
        //     else if (left == true)
        //     {
        //         Perfactscore;
        //         currentMultiplier++;
        //     }
        //     else if (right == true)
        //     {
        //         Perfactscore;
        //         currentMultiplier++;
        //     }
        //     else if (topG == true)
        //     {
        //         Goodscore;
        //         currentMultiplier++;
        //     }
        //     else if (downG == true)
        //     {
        //         Goodscore;
        //         currentMultiplier++;
        //     }
        //     else if (leftG == true)
        //     {
        //         Goodscore;
        //         currentMultiplier++;
        //     }
        //     else if (rightG == true)
        //     {
        //         Goodscore;
        //         currentMultiplier++;
        //     }
        //     else
        //     {
        //         currentMultiplier = 0;
        //     }
        //     scoreText.text = currentScore.ToString();
        //     multiText.text = currentMultiplier.ToString();
        // }
    }
    public void NoteHitPerfact()
    {
        if(currentMultiplier - 1 < multplierThresholds.Length)
        {
            multiplierTracker++;

            if (multplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }
        multiText.text = "X" + currentMultiplier;

        currentScore += Perfactscore * currentMultiplier;
        scoreText.text = " " + currentScore;

    }
    public void NoteHitGood()
    {
        if(currentMultiplier - 1 < multplierThresholds.Length)
        {
            multiplierTracker++;

            if (multplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }
        multiText.text = "X" + currentMultiplier;

        currentScore += Goodscore * currentMultiplier;
        scoreText.text = " " + currentScore;

    }
    public void NoteMissed()
    {
        currentMultiplier = 1;
        multiplierTracker = 0;

        multiText.text = "X1" + currentMultiplier;
    }
}
