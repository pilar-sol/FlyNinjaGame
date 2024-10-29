using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySpawner : MonoBehaviour
{
    public GameObject flyPrefab; // Assign FlyPrefab here
    public int fliesPerWave = 2; // Number of flies per spawn wave
    public float spawnInterval = 2f; // Time between waves

    private float timer;

    void Start()
    {
        timer = spawnInterval; // Initialize the timer
    }

    void Update()
    {
        // Count down the timer
        timer -= Time.deltaTime;
        
        if (timer <= 0)
        {
            SpawnWaveOfFlies();
            timer = spawnInterval; // Reset the timer
        }
    }

    void SpawnWaveOfFlies()
    {
        for (int i = 0; i < fliesPerWave; i++)
        {
            // Generate a random position within screen bounds
            Vector2 spawnPosition = new Vector2(
                Random.Range(-8f, 8f),
                Random.Range(-4f, 4f)
            );

            // Instantiate the fly prefab at the random position with no rotation
            Instantiate(flyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
