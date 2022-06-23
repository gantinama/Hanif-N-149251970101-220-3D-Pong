using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ScoreManager : MonoBehaviour
{
    public int player1Score;
    public int player2Score;
    public int player3Score;
    public int player4Score;

    public int maxScore;

    public BallController ball;

    private void Update() 
    {
        
    }

    public void AddPlayer1Score(int increment) 
    { 
        player1Score += increment;
        ball.ResetBall(); 
        // GameObject.Find("Ball").SetActive(false);
    } 
 
    public void AddPlayer2Score(int increment) 
    { 
        player2Score += increment;
        ball.ResetBall();
        // GameObject.Find("Ball").SetActive(false);
    }
    
    public void AddPlayer3Score(int increment) 
    { 
        player3Score += increment;
        ball.ResetBall(); 
        // GameObject.Find("Ball").SetActive(false);
    } 
 
    public void AddPlayer4Score(int increment) 
    { 
        player3Score += increment;
        ball.ResetBall();
        // GameObject.Find("Ball").SetActive(false);
    } 
 
    public void GameOver() 
    { 
        SceneManager.LoadScene("Main Menu");
    } 
}
