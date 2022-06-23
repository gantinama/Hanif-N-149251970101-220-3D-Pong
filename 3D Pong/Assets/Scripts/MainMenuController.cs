using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class MainMenuController : MonoBehaviour
{
    public Text winner;

    private void Start() {
        winner.text = VariableList.champion.ToString();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created By Hanif Naufalianto-149251970101-220");
    }

    public void HowToPlay() 
    { 
        SceneManager.LoadScene("How To Play");
    }
    
    public void MainMenu() 
    { 
        SceneManager.LoadScene("Main Menu");
    } 

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Keluar");
    }


}
