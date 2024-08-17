using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddToScore : MonoBehaviour
{
    public Text scoreText;

    private static int score = 0;

    public void IncreaseScore()
    {
        score = score + 1;
        scoreText.text = "SCORE: " + score;
        GameManager.Instance.AddOneToScore();
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = "SCORE: " + score;
    }

}
