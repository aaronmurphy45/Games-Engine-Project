using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
   // This script is used to restart the game or quit from the game over menu
    public void PlayGame()
    {
       SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    } 
}
