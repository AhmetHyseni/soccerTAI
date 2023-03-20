using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{
    [Header("Settings")]
    public Transform ball;
    public Transform p1;
    private Vector2 moveLocation;
    public Rigidbody2D rb;
    public float speed;
    private float ballLocation;
    public float jumpForce;
    private float tempTime;
    private bool avoidPlayer = false;
    private bool ballOnOwnHalf = true;

    [Header("Ray Cast")]
    public Vector2 pivotPoint = Vector2.zero;
    public float range = 5.0f;
    public float angle;
    public float angle2;
    public float angle3;

    private Vector2 startPoint = Vector2.zero;

<<<<<<< HEAD
=======


>>>>>>> parent of 994c32b (ai parannuksia)
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        startPoint = (Vector2)transform.position + pivotPoint;
        Vector2 direction = GetDirectionVector2D(angle);
        Vector2 direction2 = GetDirectionVector2D(angle2);
        Vector2 playerDirection = (ball.position - transform.position).normalized;

<<<<<<< HEAD
=======


>>>>>>> parent of 994c32b (ai parannuksia)
        Physics2D.Raycast(startPoint, direction, range);
        Physics2D.Raycast(startPoint, direction2, range);
        Physics2D.Raycast(startPoint, playerDirection, range);
        Debug.DrawRay(startPoint, direction * range, Color.green);
        Debug.DrawRay(startPoint, direction2 * range, Color.green);
        Debug.DrawRay(startPoint, playerDirection * range, Color.green);
        JumpCooldown();
<<<<<<< HEAD

        // Check if the ball is on the AI's half of the field
        if (ball.position.x < transform.position.x)
        {
            ballOnOwnHalf = true;
        }
        else
        {
            ballOnOwnHalf = false;
        }
=======
>>>>>>> parent of 994c32b (ai parannuksia)
    }

    public Vector2 GetDirectionVector2D(float angle)
    {
        return new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad)).normalized;
    }

    void FixedUpdate()
    {
        AvoidPlayer();
        NoOwnGoal();
        ballLocation = ball.position.x - transform.position.x;
        float ballLocationY = ball.position.y - transform.position.y;
<<<<<<< HEAD

        // If the ball is on the AI's half of the field, follow it as usual
        if (ballOnOwnHalf || Mathf.Abs(ballLocation) < 300f)
        {
            moveLocation = new Vector2(ballLocation, 0);
=======
        moveLocation = new Vector2(ballLocation, 0);

        if (avoidPlayer == false)
        {
>>>>>>> parent of 994c32b (ai parannuksia)
            rb.AddForce(moveLocation.normalized * speed);
        }
    }

    void JumpCooldown()
    {
        if (ball.transform.position.y > transform.position.y)
        {
            tempTime += Time.deltaTime;
            if (tempTime >= 2f)
            {
                Vector2 jumpDirection = (ball.transform.position - transform.position).normalized;
                rb.AddForce(jumpDirection * jumpForce, ForceMode2D.Impulse);
                tempTime = 0;
            }
<<<<<<< HEAD
        }
=======
      }
                       
        
        //Debug.Log(tempTime);
>>>>>>> parent of 994c32b (ai parannuksia)
    }

    void NoOwnGoal()
    {
        float tempBallLocation = ball.position.x;
        float tempAiLocation = transform.position.x;

        if (tempBallLocation > tempAiLocation)
        {
            rb.AddForce(Vector2.right * speed);
        }
    }

    void AvoidPlayer()
    {
        if (p1.transform.position.x > transform.position.x && ball.transform.position.x > transform.position.x)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            avoidPlayer = true;
            Debug.Log("Touching Player 1!");
<<<<<<< HEAD
=======
        }
        else
        {
            avoidPlayer = false;
>>>>>>> parent of 994c32b (ai parannuksia)
        }
    }
}
