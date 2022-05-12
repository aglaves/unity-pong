using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI computerScoreText;
    private int playerScore;
    private int computerScore;
    

    public void PlayerScored()
    {
        playerScore++;
        this.playerScoreText.text = playerScore.ToString();
        Debug.Log("Player Score: " + playerScore);
        ball.RestartBall();
    }

    public void ComputerScored()
    {
        computerScore++;
        this.computerScoreText.text = computerScore.ToString();
        Debug.Log("Computer Score: " + computerScore);
        ball.RestartBall();
    }
}
