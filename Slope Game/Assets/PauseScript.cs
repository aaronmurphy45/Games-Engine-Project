using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

   
    void Start(){
        Debug.Log("start");
       pauseMenuUI.SetActive(false);
    }
    void Update(){
        if (Input.GetKeyDown("p"))
        {
            
            
            if (GameIsPaused)
            {
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameIsPaused = false;
            }
            else
            {
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameIsPaused = true;
            }
        }
    }
    /*
    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    */
}
