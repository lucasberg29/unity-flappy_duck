using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdsParallax : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 startPosition = transform.position;
        startPosition.x = Random.Range(-12.0f, -17.0f);
        startPosition.y = Random.Range(1.85f, 4.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x -= speed * Time.deltaTime;

        if (position.x > 23.7f)
        {
            position.x = Random.Range(-12.0f, -17.0f);
            position.y = Random.Range(1.85f, 4.0f);
        }
        transform.position = position;
    }
}
