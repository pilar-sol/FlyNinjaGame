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
        float halfHeight = mainCamera.orthographicSize;
        float halfWidth = mainCamera.aspect * halfHeight;

        minX = -halfWidth;
        maxX = halfWidth;
        minY = -halfHeight;
        maxY = halfHeight;
    }
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = mainCamera.ScreenToWorldPoint(mousePos);
        mousePos.z = 0; 

        float clampedX = Mathf.Clamp(mousePos.x, minX, maxX);
        float clampedY = Mathf.Clamp(mousePos.y, minY, maxY);
        transform.position = new Vector3(clampedX, clampedY, 0);

        if (Input.GetMouseButtonDown(0))
        {
            Swat();
        }
    }
    void Swat()
    {
        Collider2D[] hits = Physics2D.OverlapBoxAll(transform.position, GetComponent<BoxCollider2D>().size, 0);

        foreach (var hit in hits)
        {
            if (hit.CompareTag("Fly"))
            {
                hit.GetComponent<Fly>().OnSwat(); 
            }
            else if (hit.CompareTag("Bird"))
            {
                // Handle bird swatting logic
                Debug.Log("Bird swatted! Deducting a life.");
                LifeManager lifeManager = FindObjectOfType<LifeManager>();
                if (lifeManager != null)
                {
                    lifeManager.ReduceLife(hit.transform.position); // Deduct a life
                }
                Destroy(hit.gameObject); // Destroy the bird
            }
        }
    }
}
