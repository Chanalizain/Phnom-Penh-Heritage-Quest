using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public LayerMask roadLayer; // assign in Inspector

    private Rigidbody2D rb;
    private Vector2 moveDir;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Reset move direction
        moveDir = Vector2.zero;

        // WASD keys
        if (Input.GetKey(KeyCode.W)) moveDir += Vector2.up;
        if (Input.GetKey(KeyCode.S)) moveDir += Vector2.down;
        if (Input.GetKey(KeyCode.A)) moveDir += Vector2.left;
        if (Input.GetKey(KeyCode.D)) moveDir += Vector2.right;

        // Arrow keys
        if (Input.GetKey(KeyCode.UpArrow)) moveDir += Vector2.up;
        if (Input.GetKey(KeyCode.DownArrow)) moveDir += Vector2.down;
        if (Input.GetKey(KeyCode.LeftArrow)) moveDir += Vector2.left;
        if (Input.GetKey(KeyCode.RightArrow)) moveDir += Vector2.right;

        moveDir.Normalize(); // diagonal movement speed fix
    }

    void FixedUpdate()
    {
        if (moveDir != Vector2.zero)
        {
            Vector2 newPos = rb.position + moveDir * moveSpeed * Time.fixedDeltaTime;

            // Check if next position overlaps a road collider
            Collider2D hit = Physics2D.OverlapBox(newPos, rb.GetComponent<Collider2D>().bounds.size * 0.9f, 0f, roadLayer);
            if (hit != null)
            {
                rb.MovePosition(newPos);
            }
        }
    }
}
