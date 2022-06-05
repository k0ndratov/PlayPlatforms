using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    private Collider2D coll;
    public LayerMask groundLayer;

    [Range(0, 15)]
    public float moveSpeed;
    [Range(0, 15)]
    public float jumpForce;

    private void Awake()
    {
        coll = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        float moveDirectional = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(moveDirectional * moveSpeed, rb.velocity.y);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, groundLayer);
    }
}
