using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySwatterController : MonoBehaviour
{
    private Camera mainCamera;
    private float minX, maxX, minY, maxY;

    void Start()
    {
        mainCamera = Camera.main;
        // Calculate screen boundaries in world units
        float halfHeight = mainCamera.orthographicSize;
        float halfWidth = mainCamera.aspect * halfHeight;

        // Set boundary limits based on camera size
        minX = -halfWidth;
        maxX = halfWidth;
        minY = -halfHeight;
        maxY = halfHeight;
    }
    void Update()
    {
        // Get the mouse position in world space
        Vector3 mousePos = Input.mousePosition;
        mousePos = mainCamera.ScreenToWorldPoint(mousePos);
        mousePos.z = 0; // Keep Z position fixed

        // Clamp the position to keep the swatter within screen bounds
        float clampedX = Mathf.Clamp(mousePos.x, minX, maxX);
        float clampedY = Mathf.Clamp(mousePos.y, minY, maxY);
        transform.position = new Vector3(clampedX, clampedY, 0);

        // Detect left-click or tap input
        if (Input.GetMouseButtonDown(0))
        {
            Swat();
        }
    }

    void Swat()
    {
        // Detect colliders in the area of the swatter
        Collider2D[] hits = Physics2D.OverlapBoxAll(transform.position, GetComponent<BoxCollider2D>().size, 0);

        foreach (var hit in hits)
        {
            if (hit.CompareTag("Fly"))
            {
                // Call the fly's swat function
                hit.GetComponent<Fly>().OnSwat();
            }
        }
    }
}
    /*
    void Update()
    {
        // Move the swatter to follow the mouse position
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Mathf.Abs(mainCamera.transform.position.z); // Set Z to the distance from the camera
        Vector3 worldPos = mainCamera.ScreenToWorldPoint(mousePos);
        transform.position = new Vector3(worldPos.x, worldPos.y, 0); // Set Z to 0 to keep swatter visible

        // Detect left-click or tap input
        if (Input.GetMouseButtonDown(0))
        {
            Swat();
        }
    }

    void Swat()
    {
        // Detect colliders in the area of the swatter
        Collider2D[] hits = Physics2D.OverlapBoxAll(transform.position, GetComponent<BoxCollider2D>().size, 0);

        foreach (var hit in hits)
        {
            if (hit.CompareTag("Fly"))
            {
                // Call the fly's swat function
                hit.GetComponent<Fly>().OnSwat();
            }
        }
    }
}
*/