using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_script : MonoBehaviour
{
    public float speed = 2f;
    Vector2 direction;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = Vector2.one.normalized;

    }
    private void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("margin"))
        {
            direction.y = -direction.y;
        }
        if (collision.gameObject.gameObject.CompareTag("racket"))
        {
            direction.x = -direction.x;
        }
    }
    
}
