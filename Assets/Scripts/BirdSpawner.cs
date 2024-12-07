using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public GameObject birdPrefab; // Assign the Bird prefab
    public float spawnInterval = 10f; // Time between bird spawns
    public float birdSpeed = 3f; // Speed of the bird

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnBird();
            timer = 0f; // Reset timer
        }
    }

    void SpawnBird()
    {
        // Spawn the bird at a random vertical position off-screen
        float yPosition = Random.Range(-3f, 3f); // Adjust range based on your scene
        Vector3 spawnPosition = new Vector3(-10f, yPosition, 0); // Off-screen to the left
        GameObject bird = Instantiate(birdPrefab, spawnPosition, Quaternion.identity);

        // Make the bird move across the screen
        bird.GetComponent<Rigidbody2D>().velocity = new Vector2(birdSpeed, 0); // Move right
    }
}
