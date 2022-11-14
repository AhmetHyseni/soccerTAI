using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 15f;
    bool isGrounded = true;
    public float jumpPower = 300f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        playermovement();
    }

    void playermovement()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, rb.velocity.y);

        if (Input.GetKey(KeyCode.W) && isGrounded==true)
        {
            Debug.Log("Hyppy on saatavilla");
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Ground")
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "Ground")
        {
            isGrounded = false;
        }
    }
}