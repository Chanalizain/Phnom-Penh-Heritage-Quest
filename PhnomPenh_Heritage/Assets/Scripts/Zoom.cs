using UnityEngine;
using Cinemachine;

public class CameraZoom2D : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;

    public float zoomSpeed = 2f;
    public float minZoom = 3f;   // zoom in limit
    public float maxZoom = 8f;   // zoom out limit

    void Update()
    {
        // Mouse wheel
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0)
        {
            Zoom(-scroll * zoomSpeed);
        }

        // Keyboard
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            Zoom(-zoomSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Zoom(zoomSpeed * Time.deltaTime);
        }
    }

    void Zoom(float amount)
    {
        float size = vcam.m_Lens.OrthographicSize;
        size = Mathf.Clamp(size + amount, minZoom, maxZoom);
        vcam.m_Lens.OrthographicSize = size;
    }
}
