using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isBeingPushed = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (!isBeingPushed)
        {
            rb.velocity = Vector2.zero;
        }
    }
    public void Push(Vector2 direction, float speed)
    {
        rb.velocity = direction * speed * 0.5f;
        isBeingPushed = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isBeingPushed = false;
        }
    }
}
