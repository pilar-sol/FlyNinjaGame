using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSpawner : MonoBehaviour
{
    public GameObject dogPrefab; // Assign the DogPrefab here
    public float spawnInterval = 10f; // Time between dog spawns
    public float jumpForce = 10f; // Force for the dog to jump

    private float timer;

    void Start()
    {
        timer = spawnInterval;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            SpawnDog();
            timer = spawnInterval; // Reset the timer
        }
    }

    void SpawnDog()
    {
        // Spawn the dog at a random position along the bottom of the screen
        float xPosition = Random.Range(-7f, 7f);
        Vector2 spawnPosition = new Vector2(xPosition, -5f); 
        GameObject dog = Instantiate(dogPrefab, spawnPosition, Quaternion.identity);

        // Make the dog jump by applying a vertical force
        Rigidbody2D rb = dog.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
