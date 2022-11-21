using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller2 : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 150f;
    bool isGrounded = true;
    float movementX;
    public float jumpPower = 300f;
    void Start()
    {
        movementX = 0;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        player1Input();
    }
    void FixedUpdate()
    {
        playermovement1();
    }
    void player1Input()
    {
        Debug.Log("MovementX arvo on: "+ movementX);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movementX = -1f*speed;
            
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementX = 1f*speed;
        }
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            movementX = 0f;
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow))
        {
            movementX = 0f;
        }
    }
    void playermovement1()
    {   
        rb.velocity = new Vector2(movementX, rb.velocity.y);

        if (Input.GetKey(KeyCode.UpArrow) && isGrounded==true)
        {
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