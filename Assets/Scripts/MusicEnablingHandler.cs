using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicEnablingHandler : MonoBehaviour
{
    public Button uiButton;  // Reference to the UI Button

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detect left mouse button click
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (GetComponent<EdgeCollider2D>().OverlapPoint(mousePosition))
            {
                uiButton.onClick.Invoke();  // Trigger the UI Button's onClick event
            }
        }
    }

}
