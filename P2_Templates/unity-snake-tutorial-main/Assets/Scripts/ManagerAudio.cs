using UnityEngine;

public class ManagerAudio : MonoBehaviour
{
 [Header("--- Audio Source ---")]
 [SerializeField] AudioSource musicSource;


[Header("--- Audio Clip ---")]
 public AudioClip background;

public static ManagerAudio instance;

 public void Awake()

 {
     if (instance == null)
{
    instance = this;
    DontDestroyOnLoad(gameObject);
}
else
{
    Destroy(gameObject);
}
   }
//  {
//    DontDestroyOnLoad(gameObject);
//  }
 
 private void Start()
 {
    musicSource.clip = background;
    musicSource.Play();
 }
}
