using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; 

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    public int scoreToAdvance = 15;

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();

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
        SceneManager.LoadScene("Level2"); 
    }
}
