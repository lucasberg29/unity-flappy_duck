using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Ui : MonoBehaviour
{
    private static Ui _uiInstance;

    private void Awake()
    {
        if (_uiInstance != null && _uiInstance != this)
        {
            Destroy(this);
        }
        else
        {
            _uiInstance = this;
        }

    }

    public static Ui Instance
    {
        get
        {
            if (!_uiInstance)
            {
                var gameManagerPrefab = Resources.Load<GameObject>("Tools/_GameManager");
                var gameManagerObject = Instantiate<GameObject>(gameManagerPrefab);

                _uiInstance = gameManagerObject.GetComponentInChildren<Ui>();

                if (!_uiInstance)
                {
                    _uiInstance = gameManagerObject.AddComponent<Ui>();
                }

                DontDestroyOnLoad(_uiInstance.transform.root.gameObject);
            }
            return _uiInstance;
        }
    }

    public void OpenDeletePopUp(Canvas canvas)
    {
        canvas.gameObject.SetActive(true);
    }

    public void CloseDeletePopUp(Canvas canvas)
    {
        canvas.gameObject.SetActive(false);
    }

    public void PlayerLog(string message)
    {
        //GameObject canvasUI = GameObject.FindGameObjectWithTag("Ui");
        //var updateTextPrefab = Resources.Load<GameObject>("Tools/UpdateText");
        
        //GameObject gameManagerObject = Instantiate(updateTextPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        //gameManagerObject.GetComponentInChildren<TextMeshProUGUI>().SetText(message);
        //gameManagerObject.transform.SetParent(canvasUI.transform);   
        //gameManagerObject.SetActive(true);
    }
}
