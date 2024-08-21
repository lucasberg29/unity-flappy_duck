using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchActiveGameObject : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject gameObject2;

    public void SwitchActive()
    {
        gameObject1.SetActive(!gameObject1.activeSelf);
        gameObject2.SetActive(!gameObject2.activeSelf);
    }
}
