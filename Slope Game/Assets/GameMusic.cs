using UnityEngine;


public class GameMusic : MonoBehaviour {
public AudioSource audio2;
public bool gamestart1 = false;
public bool gamestart2 = false;
public bool gamestart3 = false;
public bool checke = false;
        // Use this for initialization
        void Start () {
            audio2.volume = 0;
        }
        
        // Update is called once per frame
        void Update () {

        if (gamestart1 && gamestart2 && checke==false || gamestart3 == true && checke == false){
                audio2.volume = 0.5f;
                
                checke = true;
        }
        // This if makes the speed of the ball faster when the space key is pressed 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //speed = speed + 10;
            gamestart3 = true;
        }
            
        }
}