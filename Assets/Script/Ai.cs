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
    private float tempTime;
    Ray2D ray;

   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        JumpCooldown();
    }
    void FixedUpdate()
    {
        NoOwnGoal();
        ballLocation = ball.position.x - transform.position.x;
        float ballLocationY = ball.position.y - transform.position.y;
        moveLocation = new Vector2(ballLocation, 0);
        rb.AddForce(moveLocation.normalized * speed);
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
      }
                       
        
        Debug.Log(tempTime);
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

}
