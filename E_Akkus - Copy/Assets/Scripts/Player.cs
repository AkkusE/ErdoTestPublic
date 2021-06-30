using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Vector3 moveInput;
    public float speed;
    Rigidbody2D rb;
    private Animator anim;
    private float xInput;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private bool isGrounded;
    public float jumpForce;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
       anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Feedback: Do not keep on using empty functions due to performance

    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
        Jump();
        CheckDirection();

        anim.SetBool("isGrounded",isGrounded);
        anim.SetFloat("speed",Mathf.Abs(rb.velocity.x)); //Walk animation - with Mathf.Absolute, it'll set speed both + and -
    }

    void FixedUpdate()
    {
        // Feedback: Do not keep on using empty functions due to performance

    }



    void CheckDirection()
    {
        if (rb.velocity.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (rb.velocity.x >0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    /// <summary>
    /// Feedback: Why are you getting...             GetComponent<SpriteRenderer>().flipX = true;

    /// </summary>

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            // Input.GetButtonDown("Jump")   
        {
            if(isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                anim.SetTrigger("Jump");
                SoundManager.PlaySound("jumbo");
            }
        }
    }
    
}

