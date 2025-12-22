using UnityEngine;

public class HorizontalRoomScroll : MonoBehaviour
{
    public float scrollSpeed = 0.01f;   // For mouse/touch drag
    public float keyScrollSpeed = 5f;   // For arrow key scrolling
    public float minX = -10f;
    public float maxX = 10f;

    private Vector3 lastPointerPosition;

    void Update()
    {
        HandleMouseDrag();
        HandleArrowKeys();
    }

    private void HandleMouseDrag()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastPointerPosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - lastPointerPosition;
            float moveX = -delta.x * scrollSpeed;

            float newX = Mathf.Clamp(transform.position.x + moveX, minX, maxX);
            transform.position = new Vector3(newX, transform.position.y, transform.position.z);

            lastPointerPosition = Input.mousePosition;
        }
    }

    private void HandleArrowKeys()
    {
        float inputX = Input.GetAxisRaw("Horizontal"); // -1 for left, 1 for right
        if (inputX != 0)
        {
            float newX = Mathf.Clamp(
                transform.position.x + inputX * keyScrollSpeed * Time.deltaTime,
                minX,
                maxX
            );
            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        }
    }
}
