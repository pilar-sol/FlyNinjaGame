using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    public void OnSwat()
    {
        scoreManager.AddScore(1);

        // Destroy the fly object
        Destroy(gameObject);
    }
}
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public AudioClip splatSound; // Assign the splat sound in the Inspector
    //private AudioSource audioSource;

    private ScoreManager scoreManager;

    void Start()
    {
        // Add an AudioSource component for playing the splat sound
        //audioSource = gameObject.AddComponent<AudioSource>();

        // Find the ScoreManager in the scene
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    public void OnSwat()
    {
        AudioManager.instance.PlaySplatSound(splatSound); // Use global AudioManager
        scoreManager.AddScore(1); // Increment the score

        // Destroy the fly object
        Destroy(gameObject);
    }

}
*/