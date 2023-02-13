using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{
    [Header("Settings")]
    public Transform ball;
    private Vector2 moveLocation;
    public Rigidbody2D rb;
    public float speed;
    private float ballLocation;
    public float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        ballLocation = ball.position.x - transform.position.x;
        float ballLocationY = ball.position.y - transform.position.y;
        moveLocation = new Vector2(ballLocation, 0);
        rb.AddForce(moveLocation.normalized * speed);

        Vector3 jumpLocation = ball.position - transform.position;
        float dist = Vector3.Distance(ball.position, transform.position);
        if (dist < 150 && ballLocationY > 50)
        {
            Debug.Log("Jump");
            rb.AddForce(jumpLocation.normalized * jumpForce, ForceMode2D.Impulse);
        }
    }
}
