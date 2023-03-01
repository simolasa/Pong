using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class right_racket_script : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    public InputAction playerControls;

    Vector2 moveDirection = Vector2.zero;
    private void OnEnable()
    {
        playerControls.Enable();
    }
    private void OnDisable()
    {
        playerControls.Disable();
    }



    void Update()
    {
        moveDirection = playerControls.ReadValue<Vector2>();

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

    }
}