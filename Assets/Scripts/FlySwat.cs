using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySwat : MonoBehaviour
{
    public int scoreValue = 1;
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    private void OnMouseDown()
    {
        scoreManager.AddScore(scoreValue);
        Destroy(gameObject);
    }
}
