using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
   public TMP_Text scoreText;
   private int score = 0;
   private int targetScore = 15; 
   private string nextSceneName = "Win";

    void Update()
    {
        // Check if the score reaches or exceeds the target
        if (score == targetScore)
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
   
   private void Start()
   {
    UpdateScore();
   }

   public void AddScore()
   {
    score++;
    UpdateScore();
   }

   private void UpdateScore()
   {
    scoreText.text = "Score: " + score;
   }

   public void ResetScore()
   {
    score = 0;
    UpdateScore();
   }

}
