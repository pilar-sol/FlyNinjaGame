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
    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    int nextSceneIndex = currentSceneIndex + 1;

    if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
    {
        Debug.Log("Level Complete! Transitioning to next scene...");
        SceneManager.LoadScene(nextSceneIndex);
    }
    else
    {
        Debug.Log("No more levels! Returning to Main Menu.");
        SceneManager.LoadScene("MainMenu"); // Load Main Menu if no more levels
    }
}

    /**void AdvanceToNextLevel()
    {
        Debug.Log("Level Complete! Transitioning to Next Level...");
        SceneManager.LoadScene("Level2"); 
    }*/
}
