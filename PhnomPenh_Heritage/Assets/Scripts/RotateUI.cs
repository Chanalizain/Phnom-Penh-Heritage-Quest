using UnityEngine;

public class RotateUI : MonoBehaviour
{
    public float rotationSpeed = 50f; // degrees per second

    void Update()
    {
        // Rotate from right to left (counter-clockwise)
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
