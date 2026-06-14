using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float runSpeed = 8f;
    public float jumpForce = 8f;

    public AudioSource audioSource;
    public AudioClip jumpSound;

    private Rigidbody2D rb;
    private Animator animator;
    private bool isGrounded;
    private bool isClimbing;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (isClimbing)
        {
            float vertical = Input.GetAxis("Vertical");

            rb.linearVelocity = new Vector2(rb.linearVelocity.x, vertical * speed);
        }

        float move = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(move));

        float currentSpeed = speed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = runSpeed;
        }

        rb.linearVelocity = new Vector2(move * currentSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);

            audioSource.PlayOneShot(jumpSound);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isClimbing = true;
            rb.gravityScale = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isClimbing = false;
            rb.gravityScale = 3;
        }
    }
}