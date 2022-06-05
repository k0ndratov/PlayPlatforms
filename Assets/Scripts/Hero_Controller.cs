using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_Controller : MonoBehaviour
{
    private Rigidbody2D rb;

    [Range(0, 15)]
    public float moveSpeed;
    [Range(0, 15)]
    public float jumpForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    private void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump!");
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
