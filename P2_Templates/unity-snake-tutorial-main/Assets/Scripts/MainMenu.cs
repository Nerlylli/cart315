using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour
{
 public void Play()
 {
    SceneManager.LoadScene("Snake");
 }

 public void Back()
 {
   SceneManager.LoadScene("Main Menu");
 }

 public void Instructions()
 {
  SceneManager.LoadScene("Instructions");
 }
}
