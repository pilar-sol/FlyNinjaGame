using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Game Over logic
        SceneManager.LoadScene("MainMenu");
    }
}
