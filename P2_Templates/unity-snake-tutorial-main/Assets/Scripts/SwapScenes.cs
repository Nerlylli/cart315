using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScenes : MonoBehaviour
{
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Snake")
        {
            AudioSource previousMusic =
                FindFirstObjectByType<AudioSource>();

            if (previousMusic != null)
            {
                previousMusic.Stop();
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().buildIndex + 1
            );
        }
    }
}