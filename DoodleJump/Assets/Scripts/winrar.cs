using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winrar : MonoBehaviour
{
    public int pointValue = 0;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.enabled)
        {
            float position = target.position.y;
            cameraFollow.stopFollowingMe();
            scoreScript.currentScore += pointValue;
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(1);
        Application.LoadLevel(3);
    }
}
