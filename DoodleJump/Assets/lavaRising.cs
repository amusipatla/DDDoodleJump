using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class lavaRising : MonoBehaviour
{
    private Vector2 currentVelocity;
    public float smoothSpeed = 3.0f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        Vector2 direction = new Vector2(0, smoothSpeed);
        rb.MovePosition(rb.position + direction * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("DED");
    }
}