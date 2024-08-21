using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    List<AudioSource> audioSources = new List<AudioSource>();

    // Start is called before the first frame update
    void Start()
    {
        audioSources = FindObjectsOfType<AudioSource>().ToList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MuteGame()
    {
        foreach(AudioSource source in audioSources)
        {
            source.mute = true;
        }
    }

    public void UnmuteGame()
    {
        foreach (AudioSource source in audioSources)
        {
            source.mute = false;
        }
    }
}
