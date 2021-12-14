using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
   // This script is used to restart the game or quit from the game over menu
   public GameObject restartButton;


   // button onclick function
    public void Update() {
        
    }
    public void Start() {
        Button btn = restartButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){
		SceneManager.LoadScene(0);
	}
}
