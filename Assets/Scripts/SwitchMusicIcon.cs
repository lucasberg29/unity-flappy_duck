using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusicIcon : MonoBehaviour
{
    public GameObject musicEnabler;
    public GameObject musicDisabler;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchIcon()
    {
        musicDisabler.SetActive(!musicDisabler.activeSelf);
        musicEnabler.SetActive(!musicEnabler.activeSelf);
    }
}
