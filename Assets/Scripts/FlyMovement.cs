using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMovement : MonoBehaviour
{
    private float speed =2f;
    private Vector2 direction;

    void Start()
    {
        // Randomize the initial direction for each fly
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-0.5f, 0.5f)).normalized;
    }

    void Update()
    {
        // Move the fly in the chosen direction
        transform.Translate(direction * speed * Time.deltaTime);

        // Destroy the fly if it moves off the screen (optional)
        Vector3 screenPoint = Camera.main.WorldToViewportPoint(transform.position);
        if (screenPoint.x < 0 || screenPoint.x > 1 || screenPoint.y < 0 || screenPoint.y > 1)
        {
            Destroy(gameObject);
        }
    }
}

/*
using UnityEngine;

public class FlyMovement : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        // Move the fly randomly
        Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        transform.Translate(randomDirection * speed * Time.deltaTime);

        // Keep the fly within screen bounds (customize based on your screen size)
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp(pos.x, 0.1f, 0.9f);
        pos.y = Mathf.Clamp(pos.y, 0.1f, 0.9f);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
*/