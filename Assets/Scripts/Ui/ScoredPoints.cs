using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoredPoints : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //int points = 10;
        Vector2 position = transform.position;
        if (position.x <= -11.9)
        {
            //ScoredPoints.pointsScored(points);
        }
    }
}
