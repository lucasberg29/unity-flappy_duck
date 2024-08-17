using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EagleParallax : MonoBehaviour
{
    public float speed;

    public float xMin,xMax;
    
    public AddToScore scoreScript;

    private bool addedToScore = false;

    private Vector2 refreshPosition;

    // Start is called before the first frame update
    void Start()
    {
        scoreScript = GameObject.FindGameObjectWithTag("Score").GetComponent<AddToScore>();

        Vector2 startPosition;
        startPosition.x = Random.Range(xMin, xMax);
        startPosition.y = Random.Range(0.0f, 4.1f);
        //transform.position = startPosition;

        refreshPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x -= speed * Time.deltaTime;

        if ( position.x < -7.7f && addedToScore == false)
        {
            scoreScript.IncreaseScore();
            addedToScore = true;
        }

        if (position.x < -14.0f)
        {
            position.x = Random.Range(xMin, xMax);
            position.y = Random.Range(0.0f, 4.0f);
            addedToScore = false;
        }

        
        transform.position = position;
    }

    public void ResetPosition()
    {
        transform.position = refreshPosition;
        addedToScore = false;
    }
}
