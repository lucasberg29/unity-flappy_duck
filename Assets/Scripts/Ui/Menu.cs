using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject highestScoreText;
    float delay = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            GameManager.Instance.QuitGame();
        }
    }

    public void PlayerLog(string message)
    {
        highestScoreText.GetComponent<TextMeshProUGUI>().text = message;
        highestScoreText.SetActive(true);
        StartCoroutine(SetInactive(highestScoreText, delay));
    }

    public IEnumerator SetInactive(GameObject gameObjectToSetInactive, float delay)
    {
        yield return new WaitForSeconds(2);
        gameObjectToSetInactive.SetActive(false) ;
    }
}
