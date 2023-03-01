using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class right_racket : MonoBehaviour
{
    public Rigidbody2D _rb;
    public float _speed=500f;
    Vector2 _movement;

    private void Awake()
    {
        _rb=GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rb.AddForce(_movement * _speed *  Time.deltaTime);
    }
    public void OnMove(InputValue value)
    {
        _movement =value.Get<Vector2>();
    }
    // Start is called before the first frame update
  
}
