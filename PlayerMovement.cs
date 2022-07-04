using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    float horizontal;
    float vertical;
    public int speed = 30;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    public void FixedUpdate()
    {

        if (horizontal != 0 && vertical != 0)
        {
            rb.velocity = new Vector2(horizontal * speed / 1.3f, vertical * speed / 1.3f);
        }
        else
        {
            rb.velocity = new Vector2(horizontal * speed, vertical * speed);
        }
    }
}
