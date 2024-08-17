﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int highestScore = PlayerPrefs.GetInt("HighestScore");
        GameManager.Instance.SetHighestScore(highestScore); 
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("StartScreen");
        }
    }
}
