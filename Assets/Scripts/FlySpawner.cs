using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySpawner : MonoBehaviour
{
    public GameObject flyPrefab; 
    public int fliesPerWave = 2; 
    public float spawnInterval = 2f; 

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
            SpawnWaveOfFlies();
            timer = spawnInterval; 
        }
    }

    void SpawnWaveOfFlies()
    {
        for (int i = 0; i < fliesPerWave; i++)
        {
            Vector2 spawnPosition = new Vector2(
                Random.Range(-8f, 8f),
                Random.Range(-4f, 4f)
            );

            Instantiate(flyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
