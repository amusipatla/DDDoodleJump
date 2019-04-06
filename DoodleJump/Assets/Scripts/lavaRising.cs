using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class lavaRising : MonoBehaviour
{
    private Vector2 currentVelocity;
    public float smoothSpeed = 3.0f;
    Rigidbody2D rb;

    public Transform target;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if(cameraFollow.follow && target.position.y > rb.position.y + 20)
        {
            rb.position = new Vector2(rb.position.x, target.position.y - 15);
        }
        else
        {
            Vector2 direction = new Vector2(0, smoothSpeed);
            rb.MovePosition(rb.position + direction * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("DED");
        Application.LoadLevel(4);
    }
}