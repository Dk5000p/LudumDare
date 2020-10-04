using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public float moveInput;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public AudioClip stomp;
    private int extraJumps;
    public int extraJumpsValue;
    public int health;
    public Animator anim;
    public AudioSource boingjump;

    private void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (facingRight == false && moveInput > 0)
        {
            Flip();
           
        }
        if (facingRight == true && moveInput < 0)
        {
            Flip();
            
        }
       

    }
    private void Update()
    {
        if (isGrounded == true)
        {
            extraJumps = 2;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0|| Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
            boingjump.pitch = Random.Range(1f, 3f);
            boingjump.Play();
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
