using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour
{

    public static CurrentScore instance;


    public int currentScore;
    public int Goodscore = 100;
    public int Badscore = 50;
    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThresholds;
    int comboPoint;
    public Text scoreText;
    public Text textCombo;

    float timer = 0;

    public void Start()
    {
        instance = this;

        scoreText.text = "0";
        textCombo.text = "X 1";
        currentMultiplier = 1;
    }
    // public void Score(int score, int combo)
    // {
    //     currentScore += score;
    //     comboPoint += combo;

    //     scoreText.text = currentScore.ToString();
    //     textCombo.text = comboPoint.ToString();
    // }

    // public void Miss(int combo)
    // {
    //     comboPoint = 0;
    //     textCombo.text = comboPoint.ToString();
    // }
    public void OnhitGood()
    {
        if (currentMultiplier - 1 < multiplierThresholds.Length)
        {
            multiplierTracker++;

            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }
        textCombo.text = "X " + currentMultiplier.ToString();
        currentScore+= Goodscore * currentMultiplier;
        scoreText.text = currentScore.ToString();

    }
    public void OnhitBad()
    {
        if (currentMultiplier - 1 < multiplierThresholds.Length)
        {
            multiplierTracker++;

            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }
        textCombo.text = "X " + currentMultiplier.ToString();

        currentScore+= Badscore * currentMultiplier;
        scoreText.text = currentScore.ToString();
    }
    public void OnhitMiss()
    {
        currentMultiplier = 1;
        multiplierTracker = 0;

        textCombo.text = "X " +  currentMultiplier.ToString();
    }

}
