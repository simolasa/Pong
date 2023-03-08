using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class left_racket_script : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocity;
    void Start()
    {
        velocity = 5;
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        rb.velocity = ctx.ReadValue<Vector2>() * velocity;
    }

}
