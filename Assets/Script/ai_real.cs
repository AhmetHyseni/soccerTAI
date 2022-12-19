using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai_real : MonoBehaviour
{
    public Transform target;
    public float speed = 7.0f;
    public float minDistance = 0.09f;
    public Rigidbody2D rb2d;
    bool isGrounded = true;

    void FixedUpdate()
    {
        Vector3 dir = (target.transform.position - rb2d.transform.position).normalized;

        if (Vector3.Distance(target.transform.position, rb2d.transform.position) > minDistance)
        {
            rb2d.MovePosition(rb2d.transform.position + dir * speed * Time.fixedDeltaTime);
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
