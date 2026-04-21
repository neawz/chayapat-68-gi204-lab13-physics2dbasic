using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    float movement;

    public float JumpForce;
    public bool IsJumping;

    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement = Input.GetAxisRaw("Horizontal"); // x axis
        rb.linearVelocity = new Vector2(movement * Speed, rb.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && !IsJumping)
        {
            rb.AddForce(new Vector2(rb.linearVelocity.x, JumpForce));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
           IsJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            IsJumping = true;
        }
    }
}
