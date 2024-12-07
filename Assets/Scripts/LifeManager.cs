using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeManager : MonoBehaviour
{
    public int lives = 3; // Total lives the player starts with
    public TextMeshProUGUI livesText; // UI Text for displaying lives
    public GameObject penaltyTextPrefab; // Prefab for showing -1

    void Start()
    {
        UpdateLivesText();
    }

    public void ReduceLife(Vector3 position)
    {
        lives--;
        UpdateLivesText();

        // Show "-1" penalty at the bird's position
        GameObject penaltyText = Instantiate(penaltyTextPrefab, position, Quaternion.identity);
        penaltyText.GetComponent<TextMeshProUGUI>().text = "-1";
        Destroy(penaltyText, 1.5f); // Destroy the text after 1.5 seconds

        // Check if the player has no lives left
        if (lives <= 0)
        {
            GameOver();
        }
    }

    void UpdateLivesText()
    {
        livesText.text = "Lives: " + lives;
    }

    void GameOver()
    {
        Debug.Log("Game Over! Player has no lives left.");
        // Add logic to restart the game or go back to the MainMenu
    }
}
