using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Replace "GameScene" with the actual name of your gameplay scene
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Only for testing in the editor
        #endif
    }
}
