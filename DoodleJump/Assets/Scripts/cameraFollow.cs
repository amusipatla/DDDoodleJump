using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public Transform target;
    public float smoothSpeed = .3f;
    public static bool follow = true;

    private Vector3 currentVelocity;

    private void Start()
    {
        follow = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (follow && target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, newPos,
                        ref currentVelocity, smoothSpeed * Time.deltaTime);
        }
    }

    public static void stopFollowingMe()
    {
        follow = false;
    }
}
