using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharachMovement : MonoBehaviour
{
    public float speed;
    public float smooth;
    public Rigidbody2D rb;
    bool FacinRight = true;
    bool Grounded;
    public Collider2D GroundCheck;
    public LayerMask GroundLayer;
    public float jumpForce;
    Animator Animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        float x = Input.GetAxisRaw("Horizontal");
        Vector2 targetVelocity = new Vector2(x * speed, rb.velocity.y);
        rb.velocity = Vector2.SmoothDamp(rb.velocity, targetVelocity, ref targetVelocity, Time.deltaTime * smooth);
        //flip
        if (x > 0 && !FacinRight)
        {
            Flip();
        }
        else if (x < 0 && FacinRight)
        {
            Flip();
        }
        //groundcheck
        Grounded = GroundCheck.IsTouchingLayers(GroundLayer);
        if (Input.GetKeyDown(KeyCode.Space) && Grounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }
        //animation
        Animator.SetBool("Jumping", !Grounded);
        Animator.SetBool("Running", x != 0);
    }
    void Flip()
    {
        FacinRight=!FacinRight;
        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
