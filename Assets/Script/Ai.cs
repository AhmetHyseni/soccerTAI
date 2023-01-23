using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{
    [Header("Settings")]
    public Transform boolLocation;
    private Vector2 moveLocation;
    public Rigidbody2D rb;
    public float speed;
    private float ballLocation;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Debug.Log("ball" + ballLocation);
        Debug.Log("move" + moveLocation);
        ballLocation = boolLocation.position.x - transform.position.x;
        moveLocation = new Vector2(ballLocation, 0);
        rb.AddForce(moveLocation.normalized * speed);
    }
}
