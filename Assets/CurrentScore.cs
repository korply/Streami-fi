using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour
{

    public static CurrentScore instance;

    public Text text;
    public Text textCombo;
    public int currentScore;
    int combo;
    int comboPoint;

    float timer = 0;

    public void Start()
    {
        instance = this;
    }
    public void Score(int score, int combo)
    {
        currentScore += score;
        text.text = currentScore.ToString();

        comboPoint += combo;
        textCombo.text = comboPoint.ToString();
    }

    public void Miss(int combo)
    {
        comboPoint = 0;
        textCombo.text = comboPoint.ToString();
    }

}
