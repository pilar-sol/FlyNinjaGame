using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // For scene transitions

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    // Score required to transition to the next level
    public int scoreToAdvance = 15;

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();

        // Check if the score is high enough to advance to Level 2
        if (score >= scoreToAdvance)
        {
            AdvanceToNextLevel();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    void AdvanceToNextLevel()
    {
        Debug.Log("Level Complete! Transitioning to Next Level...");
        SceneManager.LoadScene("Level2"); // Make sure your Level 2 scene is named "Level2"
    }
}
