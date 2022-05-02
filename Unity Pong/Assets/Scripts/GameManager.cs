using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int playerScore;
    private int computerScore;

    public void PlayerScored()
    {
        playerScore++;
        Debug.Log("Player Score: " + playerScore);
        ball.ResetPosition();
    }

    public void ComputerScored()
    {
        computerScore++;
        Debug.Log("Computer Score: " + computerScore);
        ball.ResetPosition();
    }
}
