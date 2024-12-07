using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSpawner : MonoBehaviour
{
    public GameObject dogPrefab; 
    public float spawnInterval = 10f; 
    public float jumpForce = 10f; 

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
            timer = spawnInterval; 
        }
    }

    void SpawnDog()
    {
        float xPosition = Random.Range(-7f, 7f);
        Vector2 spawnPosition = new Vector2(xPosition, -5f); 
        GameObject dog = Instantiate(dogPrefab, spawnPosition, Quaternion.identity);

        Rigidbody2D rb = dog.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
