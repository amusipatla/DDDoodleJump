using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateScore : MonoBehaviour
{

    public int pointValue = 0;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.enabled && count == 0)
        {
            count++;
            scoreScript.currentScore += pointValue;
        }
    }
}
