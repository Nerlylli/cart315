using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Ball ballPrefab;

    public Paddle playerPadde;
    public Paddle computerPaddle;

    public Text PSText;
    public Text CSText;

    private int _playerScore;

    private int _computerScore;

    private void Start()
    {
        SpawnBall();
    }
    public void PlayerScores()
    {
        _playerScore++;

        this.PSText.text = _playerScore.ToString();
        // ResetRound();

        if (_playerScore % 2 == 0)
        { 
            SpawnBall();
        }

    }

    public void ComputerScores()
    {
        _computerScore++;

        this.CSText.text = _computerScore.ToString();
        // ResetRound();
    }

    private void SpawnBall()
{
    Ball newBall = Instantiate(
        ballPrefab,
        Vector3.zero,
        Quaternion.identity
    );

    newBall.AddStartingForce();

    computerPaddle.GetComponent<ComputerPaddle>().ball = 
        newBall.GetComponent<Rigidbody2D>();
}

}
