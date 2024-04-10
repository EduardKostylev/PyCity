using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 0.5f;
    public float moveInputX;
    public float moveInputY;


    private void Start () 
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    private void FixedUpdate ()
    {
        moveInputY = Input.GetAxis ("Vertical");
        rb.velocity = new Vector2(moveInputY * speed, rb.velocity.y);
         
        moveInputX = Input.GetAxis ("Horizontal");
        rb.velocity = new Vector2(moveInputX * speed, rb.velocity.x);
    }
}
