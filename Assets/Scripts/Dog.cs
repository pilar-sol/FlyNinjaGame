using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dog : MonoBehaviour
{
    private void OnMouseDown()
    {
        // When the player swats the dog, return to the Main Menu
        SceneManager.LoadScene("MainMenu"); // Replace "MainMenu" with your actual main menu scene name
    }
}
