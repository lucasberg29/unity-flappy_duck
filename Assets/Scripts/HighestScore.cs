using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighestScore : MonoBehaviour
{
    public int highestScore = 0;
    public TextMeshProUGUI uiText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateHighestScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHighestScore()
    {
        highestScore = PlayerPrefs.GetInt("HighestScore");
        uiText.text = $"Highest Score: {highestScore}";
    }
}
