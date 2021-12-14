

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


// This script controls all of the balls behaviour and also computes the score

public class Ball : MonoBehaviour {

  public Text scoreText;
  public int speed = 1;
  public float rotSpeed =30;
  public int i = 1;

  public int terrain = 0;
  public int width = 30;
  public int height = 256;
  public int score = 0;
  
  public float scale = 10f;

 
  public float offsetX = 10f;
  public float offsetY = 10f;
  public float offsetZ = 10f;
  int x = 1;
  public int z = 0;
 public int dif1 = 0;
 public int speedup = 1;
 public int angspeed = 2;

 public int lives = 3;

 public Text MyText;
 public bool checker = false;

 public bool gamestart1 = false;
public bool gamestart2 = false;

public bool gamestart3 = false;

public string highscorekey = "highscore";
public int highscore = 0; 

public Text highscoreText;

 //public AudioSource audio;
 //public AudioSource audio2;

    public bool checke =false;
  



  // This Coroutine is used to make the player Magic after hitting a Magic Box 
     IEnumerator SpecialEffect(){

        // Change the material of the ball to the Magic Material
        Material mat = Resources.Load("Special", typeof(Material)) as Material;
        GameObject.Find("Sphere").GetComponent<MeshRenderer> ().material = mat;
        // Add score
        score = score + 10;

        // Move crate to start opf course. 
        GameObject.Find("Magic Box").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        // Up the speed of the ball
        speed = 150;

        // This checker is used to determine whether the ball is in magic mode or not - used when calaculating score for glass boxes
        checker = true;

        // Stay in magic mode for 5 seconds
        yield return new WaitForSecondsRealtime(5);

        // Change the material of the ball back to the normal material and reset speed to normal speed
        speed = 30;
        checker = false;
        GameObject.Find("Sphere").GetComponent<MeshRenderer> ().material = Resources.Load("DefBall", typeof(Material)) as Material;
        
     }
     
     
    // This function is used to determine the score. It is called when the ball hits any box
     void OnTriggerEnter(Collider other) {

        // If the ball hits a cube the score will be increased by 10
         
                if (other.gameObject.name == "Cube")
                {
                    score = score + 10;
                }
                if (other.gameObject.name == "Cube1")
                {
                    score = score + 10;
                }
                if (other.gameObject.name == "Cube2")
                {
                    score = score + 10;
                
                }
                if (other.gameObject.name == "Cube3")
                {
                     score = score + 10;
                }
                if (other.gameObject.name == "Cube4")
                {
                     score = score + 10;
                }
                if (other.gameObject.name == "Cube5")
                {
                     score = score + 10;
    
                }
                if (other.gameObject.name == "Cube6")
                {
                    score = score + 10;
                }
                if (other.gameObject.name == "Cube7")
                {
                     score = score + 10;
                    
                }
                // If the ball hits a Magic Box it will start the special effect coroutine
                if (other.gameObject.name == "Magic Box")
                {
                    StartCoroutine(SpecialEffect());
               
                }

                // If the ball hits a glass box the score will be decreased by 20 if not in magic mode, in which case it will be increased by 10
                if (other.gameObject.name == "GlassBox1")
                {
                    if (checker){
                        score = score + 10;
                    }
                    if (!checker){
                        score = score - 20;
                    }
                    
                }
                if (other.gameObject.name == "GlassBox2")
                {
                    if (checker){
                        score = score + 10;
                    }
                    if (!checker){
                        score = score - 20;
                    }
                    
                }
                if (other.gameObject.name == "GlassBox3")
                {
                     if (checker){
                        score = score + 10;
                    }
                    if (!checker){
                        score = score - 20;
                    }
                }
                if (other.gameObject.name == "GlassBox4")
                {
                     if (checker){
                        score = score + 10;
                    }
                    if (!checker){
                        score = score - 20;
                    }
                }
                if (other.gameObject.name == "GlassBox5")
                {
                     if (checker){
                        score = score + 10;
                    }
                    if (!checker){
                        score = score - 20;
                    }
                }
                if (other.gameObject.name == "GlassBox6")
                {
                     if (checker){
                        score = score + 10;
                    }
                    if (!checker){
                        score = score - 20;
                    }
                }

                // If the ball hits a moving crate the score will be increased by 30
                if (other.gameObject.name == "MovingCube"){
                    score = score + 30;
                }
                if (other.gameObject.name == "MovingCube1"){
                    score = score + 30;
                }
                if (other.gameObject.name == "MovingCube2"){
                    score = score + 30;
                }
                if (other.gameObject.name == "MovingCube3"){
                    score = score + 30;
                }
                if (other.gameObject.name == "MovingCube4"){
                    score = score + 30;
                }


                

            }
        

	void Start () {
        //Time.timeScale = 1f;
        checker = false;
        //audio2.volume = 0;
        //audio.volume = 0;
        Time.timeScale = 0f;
        highscore = PlayerPrefs.GetInt(highscorekey);
        MyText.text = "Highscore: " + highscore;


        //MyText.text = "";
	}

	 void Update()
    {
            // If the ball falls out of the scene the player be met by a game over menu.
            if (GameObject.Find("Sphere").transform.position.y < -10)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
               

            }

        
            
        // When first played, the ball will start moving and break some boxes and display score even though on main menu.
        // This if makes it so if the score is =0 and the user has pressed both left and right the score will display
        if (gamestart1 && gamestart2 && checke==false || gamestart3 == true && checke == false){
                //audio2.volume = 0.5f;
                //audio.volume = 0.5f;
                Time.timeScale = 1f;
                GameObject.Find("Text").GetComponent<Text>().text = "Score: " + score;
                highscoreText.text = "Highscore: " + highscore;
                speed = 30;
                
                checke = true;
        }
        if (checke){
            GameObject.Find("Text").GetComponent<Text>().text = "Score: " + score;
            if (score > highscore){
                highscore = score;
                PlayerPrefs.SetInt(highscorekey, highscore);
            }
        }
        // This if makes the speed of the ball faster when the space key is pressed 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed = speed + 10;
            gamestart3 = true;
        }
        // This if makes the speed quiker as the score increases.
        
        if (score > 1000*i)
        {
            speed = speed + 10;
            i++;
            
        }


        // If statements that stop the rotation of both the camera and the ball. 
        // I put these in as when the ball hits a crate and the cracked crate is spawned, the ball sometimes hits the carte and the camera starts rotating 

        if (GameObject.Find("Sphere").transform.rotation.z!=0){
                GameObject.Find("Sphere").transform.rotation = Quaternion.Euler(0,0,0);
            }
            if (GameObject.Find("Sphere").transform.rotation.y!=0){
                GameObject.Find("Sphere").transform.rotation = Quaternion.Euler(0,0,0);
            }
            if (GameObject.Find("Sphere").transform.rotation.x!=0){
                GameObject.Find("Sphere").transform.rotation = Quaternion.Euler(0,0,0);
            }

        if (GameObject.Find("Camera").transform.rotation.z!=-6){
                GameObject.Find("Camera").transform.rotation = Quaternion.Euler(6,-3,-6);
            }
            if (GameObject.Find("Camera").transform.rotation.y!=-3){
                GameObject.Find("Camera").transform.rotation = Quaternion.Euler(6,-3,-6);
            }
            if (GameObject.Find("Camera").transform.rotation.x!=6){
                GameObject.Find("Camera").transform.rotation = Quaternion.Euler(6,-3,-6);
            }


        

        // This if makes the ball move in the direction of the camera.
        transform.position += Vector3.forward * Time.deltaTime * speed ;//* speedup;

        //This if makes the ball move left if Left key is pressed.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Move object across XY plane
            gamestart1 = true;
            transform.Translate(Vector3.left *Time.deltaTime *5);

        }
         //This if makes the ball move right if Right key is pressed.
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Move object across XY plane
            gamestart2 = true;
            transform.Translate(Vector3.right * Time.deltaTime *5);
        }

    }
}
