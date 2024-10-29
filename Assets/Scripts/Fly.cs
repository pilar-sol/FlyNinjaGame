using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        // Locate the ScoreManager in the scene
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    public void OnSwat()
    {
        // Add a point to the score
        scoreManager.AddScore(1);

        // Destroy the fly object
        Destroy(gameObject);
    }
}
