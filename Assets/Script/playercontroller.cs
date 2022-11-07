using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 15f;
    public float jumpPower = 15f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        playermovement();
    }

    void playermovement()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, rb.velocity.y);
        if(Input.GetButton("Jump"))
        {
            rb.velocity = new Vector2(50, jumpPower);
        }
    }
}
