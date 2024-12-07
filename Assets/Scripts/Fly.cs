using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    public void OnSwat()
    {
        scoreManager.AddScore(1);

        // Destroy the fly object
        Destroy(gameObject);
    }
}
