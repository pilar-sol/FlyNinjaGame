using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // For scene transitions
using TMPro; // For TextMeshPro UI

public class LevelTimer : MonoBehaviour
{
    public float timeRemaining = 10f; 
    public TextMeshProUGUI timerText;
    public ScoreManager scoreManager; 

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.Ceil(timeRemaining).ToString();
        }
        else
        {
            EndLevel();
        }
    }

    void EndLevel()
    {
        if (scoreManager.score >= 15)
        {
            // Player wins
            Debug.Log("You win!");
            SceneManager.LoadScene("VictoryScreen"); // Replace with your victory scene name
        }
        else
        {
            // Player loses
            Debug.Log("Time's up! Returning to Main Menu.");
            SceneManager.LoadScene("MainMenu"); 
        }
    }
}
