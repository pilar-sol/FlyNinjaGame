using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Bird"))
    {
        Debug.Log("Bird swatted! Deducting a life.");
        LifeManager lifeManager = FindObjectOfType<LifeManager>();
        if (lifeManager != null)
        {
            lifeManager.ReduceLife(other.transform.position); // Show penalty and reduce lives
        }
        Destroy(other.gameObject); // Destroy the bird
    }
}
}
