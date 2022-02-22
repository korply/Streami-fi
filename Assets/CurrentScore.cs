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
    int comboPoint;

    float timer = 0;

    public void Start()
    {
        instance = this;
    }
    public void Score(int score, int combo)
    {
        currentScore += score;
        comboPoint += combo;
        
        text.text = currentScore.ToString();
        textCombo.text = comboPoint.ToString();
    }

    public void Miss(int combo)
    {
        comboPoint = 0;
        textCombo.text = comboPoint.ToString();
    }

}
