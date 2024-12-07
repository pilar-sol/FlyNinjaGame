using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySpawnerLevel3 : MonoBehaviour
{
    public GameObject flyPrefab;
    public float spawnInterval = 0.3f; // Faster spawn rate for Level 3
    public float minX, maxX, minY, maxY; 

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnFly();
            timer = 0f; 
        }
    }

    void SpawnFly()
    {
        float xPosition = Random.Range(minX, maxX);
        float yPosition = Random.Range(minY, maxY);

        Vector3 spawnPosition = new Vector3(xPosition, yPosition, 0);
        Instantiate(flyPrefab, spawnPosition, Quaternion.identity);
    }
}