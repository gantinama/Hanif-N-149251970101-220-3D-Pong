using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public ScoreManager manager;
    public PaddleController paddle;

    private string player;

    private void Update() {
        
    }

    private void OnTriggerEnter(Collider collision) {
        if (collision == ball)
        {
            // Debug.Log(gameObject.tag);
            if (ball.GetComponent<BallController>().lastPlayer == "Player 1")
            {
                manager.AddPlayer1Score(1);
                if (gameObject.tag == "Player 1")
                {
                    player = "Player 1";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }if (gameObject.tag == "Player 2")
                {
                    player = "Player 2";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }
                if (gameObject.tag == "Player 3")
                {
                    player = "Player 3";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }
                if (gameObject.tag == "Player 4")
                {
                    player = "Player 4";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }
            }
            if (ball.GetComponent<BallController>().lastPlayer == "Player 2")
            {
                manager.AddPlayer2Score(1);
                if (gameObject.tag == "Player 1")
                {
                    player = "Player 1";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }if (gameObject.tag == "Player 2")
                {
                    player = "Player 2";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }
                if (gameObject.tag == "Player 3")
                {
                    player = "Player 3";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }
                if (gameObject.tag == "Player 4")
                {
                    player = "Player 4";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }
            }
            if (ball.GetComponent<BallController>().lastPlayer == "Player 3")
            {
                manager.AddPlayer3Score(1);
                if (gameObject.tag == "Player 1")
                {
                    player = "Player 1";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }if (gameObject.tag == "Player 2")
                {
                    player = "Player 2";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }
                if (gameObject.tag == "Player 3")
                {
                    player = "Player 3";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }
                if (gameObject.tag == "Player 4")
                {
                    player = "Player 4";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }
            }
            if (ball.GetComponent<BallController>().lastPlayer == "Player 4")
            {
                manager.AddPlayer4Score(1);
                if (gameObject.tag == "Player 1")
                {
                    player = "Player 1";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }if (gameObject.tag == "Player 2")
                {
                    player = "Player 2";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }
                if (gameObject.tag == "Player 3")
                {
                    player = "Player 3";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }
                if (gameObject.tag == "Player 4")
                {
                    player = "Player 4";
                    paddle.GetComponent<PaddleController>().LosingLP(player);
                }
            }
        }
    }
}
