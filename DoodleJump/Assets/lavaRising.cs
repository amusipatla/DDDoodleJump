using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaRising : MonoBehaviour
{
    private Vector2 currentVelocity;
    public float smoothSpeed = 3.0f;

    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        Vector2 direction = new Vector2(0, smoothSpeed);
        rb.MovePosition(rb.position + direction * Time.deltaTime);
    }

}
