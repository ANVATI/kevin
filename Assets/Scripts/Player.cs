using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public int directionX;
    public int directionY;
    private Animator animator;
    private Box currentBox;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            directionX = 1;
            animator.SetFloat("MoveX", directionX);
            animator.SetFloat("MoveY", directionY);
            animator.SetBool("Moving", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            directionX = -1;
            animator.SetFloat("MoveX", directionX);
            animator.SetFloat("MoveY", directionY);
            animator.SetBool("Moving", true);
        }
        else
        {
            directionX = 0;
            animator.SetBool("Moving", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            directionY = 1;
            animator.SetFloat("MoveY", directionY);
            animator.SetFloat("MoveX", directionX);
            animator.SetBool("Moving", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            directionY = -1;
            animator.SetFloat("MoveY", directionY);
            animator.SetFloat("MoveX", directionX);
            animator.SetBool("Moving", true);
        }
        else
        {
            directionY = 0;
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed * directionX, speed * directionY);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Box")
        {
            currentBox = other.GetComponent<Box>();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Box")
        {
            currentBox = null;
        }
    }
}
