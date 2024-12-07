using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public GameObject birdPrefab; 
    public float spawnInterval = 10f; 
    public float birdSpeed = 3f; 
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
        float yPosition = Random.Range(-3f, 3f); 
        Vector3 spawnPosition = new Vector3(-10f, yPosition, 0); 
        GameObject bird = Instantiate(birdPrefab, spawnPosition, Quaternion.identity);

        bird.GetComponent<Rigidbody2D>().velocity = new Vector2(birdSpeed, 0);
    }
}
