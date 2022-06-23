using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text player1Score;
    public Text player2Score;
    public Text player3Score;
    public Text player4Score;

    public ScoreManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1Score.text = manager.player1Score.ToString();
        player2Score.text = manager.player2Score.ToString();
        player3Score.text = manager.player3Score.ToString();
        player4Score.text = manager.player4Score.ToString();
    }
}
