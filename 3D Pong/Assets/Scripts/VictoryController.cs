using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryController : MonoBehaviour
{
    public List<GameObject> playerList;
    
    private string winner;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(playerList[0]);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerList.Count == 1)
        {
            winner = playerList[0].tag;
            GameOver(winner);
            Debug.Log(playerList[0].tag);
        }
    }

    public void RemovePlayer(GameObject player)
    {
        playerList.Remove(player);
        Debug.Log("ilang si "+player);
    }

    private void GameOver(string winner)
    {
        VariableList.champion = winner;
        SceneManager.LoadScene("Victory");
    }
}
