using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class ball_script : MonoBehaviour
{
    public float speed;
    public float random_direction_x;
    public float random_direction_y;

    Vector2 direction;
    Rigidbody2D rb;


    void Start()
    {
        speed = 3;
        rb = GetComponent<Rigidbody2D>();
        Resetball();
    }
    private void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        direction.x = -direction.x;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        direction.y = -direction.y;
    }
    public void Resetball()
    {
        while (random_direction_x == 0)
        {
            random_direction_x = Random.Range(-1, 2);
        }
        while (random_direction_y == 0)
        {
            random_direction_y = Random.Range(-1, 2);
        }
        
        transform.position = new Vector3(0, 0, 0);
        direction = new Vector2(random_direction_x, random_direction_y);
    }
}
