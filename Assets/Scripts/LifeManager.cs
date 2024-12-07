using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class LifeManager : MonoBehaviour
{
    public int lives = 3; 
    public TextMeshProUGUI livesText; 
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
        Debug.Log("Game Over! Returning to Main Menu...");
        SceneManager.LoadScene("MainMenu"); 
    }
}
