using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Eagles")]
    [SerializeField]
    private EagleParallax [] eagles;

    [Header("X Range")]
    public float minX;
    public float maxX;

    [Header("Y Range")]
    public float minY;
    public float maxY;

    private void Start()
    {
        eagles = GameObject.FindObjectsOfType<EagleParallax>();

        foreach(EagleParallax eagle in eagles)
        {
            RandomizePosition(eagle);
        }
    }

    private void RandomizePosition( EagleParallax eagle )
    {
        Vector2 pos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        eagle.gameObject.transform.position = pos;
    }
}
