using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


// This script is attached to the Main Menu scene.
// It is responsible for starting the game and quiting the game on both the Main Menu and the Game Over scene.
public class MainMenu : MonoBehaviour
{
    
    // PlayGame will load the actual Game Scene (configured in Build Settings) when the Play Game button is clicked.
    public void PlayGame()
    {
       SceneManager.LoadScene(1);
    }
    // QuitGame will quit the game when the Quit Game button is clicked.
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    } 
}
