using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CanvasManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOver;

    [SerializeField]
    private AddToScore gameScore;

    [SerializeField]
    private TextMeshProUGUI scoreResult;

    [SerializeField]
    private TextMeshProUGUI highestScoreResult;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        GameManager.Instance.PauseGame();

        scoreResult.text = GameManager.Instance.GetCurrentScore().ToString();

        if (GameManager.Instance.GetCurrentScore() > GameManager.Instance.GetHighestScore())
        {
            GameManager.Instance.SetHighestScore(GameManager.Instance.GetCurrentScore());
        }

        highestScoreResult.text = GameManager.Instance.GetHighestScore().ToString();

        gameOver.SetActive(true);
        
    }

    public void ResumeGame()
    {
        gameOver.SetActive(false);

        GameManager.Instance.SetCurrentScore(0);
        gameScore.ResetScore();
    }
}
