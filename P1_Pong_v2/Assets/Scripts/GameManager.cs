using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPadde;
    public Paddle computerPaddle;

    public Text PSText;
    public Text CSText;

    private int _playerScore;

    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;

        this.PSText.text = _playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;

        this.CSText.text = _computerScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        this.playerPadde.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
