using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playermovement();
    }

    void playermovement()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, 0);
        if(Input.GetButton("Jump"))
        {
            rb.AddForce(transform.up* speed, ForceMode2D.Impulse);
        }
    }
}
