using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OceanManager : MonoBehaviour
{
    public bool isGameRunning;
    public GameObject pauseGameMenu;

    // Start is called before the first frame update
    void Start()
    {
        isGameRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameRunning)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                isGameRunning = false;
                Time.timeScale = 0.0f;
                pauseGameMenu.SetActive(true);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                isGameRunning = true;
                Time.timeScale = 1.0f;
                pauseGameMenu.SetActive(false);
            }
        }
    }

    public void ResumeOceanLevel()
    {
        Time.timeScale = 1.0f;
        isGameRunning = true;
        pauseGameMenu.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
}
