using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{
    [Header("Settings")]
    public Transform boolLocation;
    private Vector2 moveLocation;
    public Rigidbody2D rb;
    private float stoppingDistance = 0.09f;
    public float speed = 7f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
       
        moveLocation = new Vector2(boolLocation.transform.position.x, 0);
        Vector3 dir = (boolLocation.transform.position - transform.position.x).normalized;

        if (Vector3.Distance(boolLocation.transform.position, rb.transform.position) > stoppingDistance)
        {
            rb.MovePosition(rb.transform.position + dir * speed * Time.fixedDeltaTime);
        }
    }
}
