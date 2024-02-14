using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    private int player1Score;
    private int player2Score;

    public Text player1ScoreText;
    public Text player2ScoreText;
    public void Player1Scores()
    {
        player1Score++;

        ball.ResetPosition();
        player1ScoreText.text = player1Score.ToString();
    }

    public void Player2Scores()
    {
        player2Score++;

        ball.ResetPosition();
        player2ScoreText.text = player2Score.ToString();
    }


}
