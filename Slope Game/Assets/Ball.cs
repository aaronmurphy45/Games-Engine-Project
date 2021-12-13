

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

  public Text scoreText;
  public int speed = 1;
  public float rotSpeed =30;
  public int i = 1;

    //public int score = 0;
  public int terrain = 0;
  public int width = 30;
  public int height = 256;
  public int score = 0;
  //public int speedup = 1l

  // How much of the terrain you can see in the scene view
  public float scale = 10f;

  // Positional area of the terrain you can see in the scene view
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


 AudioSource audio;
 AudioSource audio2;
  
     IEnumerator SpecialEffect(){
        Material mat = Resources.Load("Special", typeof(Material)) as Material;
        GameObject.Find("Sphere").GetComponent<MeshRenderer> ().material = mat;
        score = score + 10;
        GameObject.Find("Magic Box").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        speed = 150;
        checker = true;
        yield return new WaitForSecondsRealtime(5);
        speed = 10;
        checker = false;
        GameObject.Find("Sphere").GetComponent<MeshRenderer> ().material = Resources.Load("DefBall", typeof(Material)) as Material;
        
     }
     
     
     void OnTriggerEnter(Collider other) {
         
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
                if (other.gameObject.name == "Magic Box")
                {
                    StartCoroutine(SpecialEffect());
               
                }
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
                

            }
        

	void Start () {
    
       
        GameObject.Find("Lives").GetComponent<Text>().text = "Lives: " + lives;
        checker = false;
    
        
        MyText.text = "";
	}

    int Score()
    {
        return score;
    }

  TerrainData GenerateTerrain(TerrainData terrainData) {
      terrainData.heightmapResolution = width+1;
      terrainData.size = new Vector3(width, terrain, height);
      terrainData.SetHeights(0, 0, GenerateHeights());

      return terrainData;
  }
  float[,] GenerateHeights() {
      float[,] heights = new float[width, height];
      for (int x = 0; x < width; x++) {
          for (int y = 0; y < height; y++) {
              heights[x, y] = CalculateHeight(x, y);
          }
      }
      return heights;
  }
  float CalculateHeight(int x, int y) {
      float xCoord = (float)x / width * scale + offsetX;
      float yCoord = (float)y / height * scale + offsetY;
      return Mathf.PerlinNoise(xCoord, yCoord);
  }

	 void Update()
    {

        Debug.Log(GameObject.Find("Sphere").transform.position.y);
            
            if (GameObject.Find("Sphere").transform.position.y < -10)
            {
                //SceneManager.SetActiveScene(SceneManager.GetSceneByName("GameOver"));
                //Application.LoadLevel(2);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
               

            }
        /*
        Vector3 ballPos = GameObject.Find("Sphere").transform.position;
        int camposx = (int)ballPos.x;
        int camposy = (int)ballPos.y+ 5;
        int camposz = (int)ballPos.z - 20;

        while (camposx > ballPos.x){
            camposx = camposx - 1;
            GameObject.Find("Camera").transform.position = new Vector3(camposx, camposy, camposz);
        }
        while (camposx < ballPos.x){
            camposx = camposx + 1;
            GameObject.Find("Camera").transform.position = new Vector3(camposx, camposy, camposz);
        }
        /*
        while (camposy > ballPos.y){
            camposy = camposy - 1;
            GameObject.Find("Camera").transform.position = new Vector3(camposx, camposy, camposz);
        }
        while (camposy < ballPos.y){
            camposy = camposy + 1;
            GameObject.Find("Camera").transform.position = new Vector3(camposx, camposy, camposz);
        }
        */
        
       
            

        if (score!=0){
           if (gamestart1){
               if (gamestart2){
                 GameObject.Find("Text").GetComponent<Text>().text = "Score: " + score;
               }
           }
            
            
        }
        //GameObject.Find("Text").GetComponent<Text>().text = "Score: " + score;
        
        //score = score + 1;
        //scoreText.text = "Score: " + score;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed = speed + 10;
        }
        if (score > 1000*i)
        {
            speed = speed + 10;
            
        }
        /*

        if (GameObject.Find("Sphere").transform.rotation.z!=0){
                GameObject.Find("Sphere").transform.rotation.z = 0;
            }
            if (GameObject.Find("Sphere").transform.rotation.y!=0){
                GameObject.Find("Sphere").transform.rotation.y = 0;
            }
            if (GameObject.Find("Sphere").transform.rotation.x!=0){
                GameObject.Find("Sphere").transform.rotation.x = 0;
            }

        */


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


       
        transform.position += Vector3.forward * Time.deltaTime * speed ;//* speedup;
        //GameObject.Find("Sphere").transform.Rotate(Vector3.forward, rotSpeed * Time.deltaTime);
        //GameObject.Find("Sphere").transform.Rotate(Vector3.right, rotSpeed * Time.deltaTime);

        //Detect if the left mouse button is pressed
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Move object across XY plane
            gamestart1 = true;
            transform.Translate(Vector3.left *Time.deltaTime *5);
            //transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0);
            //transform.Translate(0,0, Input.GetAxis("Verical") * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Move object across XY plane
            gamestart2 = true;
            transform.Translate(Vector3.right * Time.deltaTime *5);
            //transform.Rotate(0, Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0);
            //transform.Translate(0,0, Input.GetAxis("Verical") * speed * Time.deltaTime);
        }
        if (GameObject.Find("Sphere").transform.position.z>(256*i -100)) {
         //transform.position += Vector3.forward * Time.deltaTime * speed ;//* speedup;
            if (z == 0){
    
                //GameObject.Find("Terrain2").transform.position = new Vector3(0, 0, 256 * i - 100);
                //GameObject.Find("SpikedTerrain2").transform.position = new Vector3(-167, -220, 256 * i - 100);
                z++;
                i++;
                int min = 256*x;
                int max = 256*x+256;


                int rand = Random.Range(min, max);
                /*
                GameObject.Find("Cube").transform.position = new Vector3(10, 2, rand-100 );
                rand = Random.Range(min, max);
                GameObject.Find("Cube1").transform.position = new Vector3(20, 2, rand-100);
                rand = Random.Range(min, max);
                GameObject.Find("Cube2").transform.position = new Vector3(11,2, rand-100);
                rand = Random.Range(min, max);
                GameObject.Find("Cube3").transform.position = new Vector3(10, 2, rand-150);
                rand = Random.Range(min, max);
                GameObject.Find("Cube4").transform.position = new Vector3(14, 2, rand-200);
                rand = Random.Range(min, max);
                GameObject.Find("Cube5").transform.position = new Vector3(19, 2, rand-250);
                rand = Random.Range(min, max);
                GameObject.Find("Cube6").transform.position = new Vector3(20, 2, rand-300);
                rand = Random.Range(min, max);
                GameObject.Find("Cube7").transform.position = new Vector3(30, 2, rand-350);
                 rand = Random.Range(min, max);
                 */
                 /*
                GameObject.Find("GlassBox1").transform.position = new Vector3(10, 2, rand-120);
                rand = Random.Range(min, max);
                GameObject.Find("GlassBox2").transform.position = new Vector3(20, 2, rand-180);
                rand = Random.Range(min, max);
                GameObject.Find("GlassBox3").transform.position = new Vector3(16, 2, rand-280);
                rand = Random.Range(min, max);
                GameObject.Find("GlassBox4").transform.position = new Vector3(18, 2, rand-200);
                speedup++;
                x++;
                */
            }
            if (z==1){

            
                //GameObject.Find("Terrain1").transform.position = new Vector3(0, 0, 256 * i - 100);
                //GameObject.Find("SpikedTerrain1").transform.position = new Vector3(-167, -220, 256 * i -100);
                

                z++;
                i++;
                int min = 256*x;
                int max = 256*x+256;
                int rand = Random.Range(min, max);

                /*
               GameObject.Find("Cube").transform.position = new Vector3(10, 2, rand-100 );
                rand = Random.Range(min, max);
                GameObject.Find("Cube1").transform.position = new Vector3(20, 2, rand-400);
                rand = Random.Range(min, max);
                GameObject.Find("Cube2").transform.position = new Vector3(11,2, rand-600);
                rand = Random.Range(min, max);
                GameObject.Find("Cube3").transform.position = new Vector3(10, 2, rand-150);
                rand = Random.Range(min, max);
                GameObject.Find("Cube4").transform.position = new Vector3(14, 2, rand-200);
                rand = Random.Range(min, max);
                GameObject.Find("Cube5").transform.position = new Vector3(19, 2, rand-250);
                rand = Random.Range(min, max);
                GameObject.Find("Cube6").transform.position = new Vector3(20, 2, rand-300);
                rand = Random.Range(min, max);
                GameObject.Find("Cube7").transform.position = new Vector3(30, 2, rand-350);
                */
                /*
                 rand = Random.Range(min, max);
                GameObject.Find("GlassBox1").transform.position = new Vector3(10, 2, rand-120);
                rand = Random.Range(min, max);
                GameObject.Find("GlassBox2").transform.position = new Vector3(20, 2, rand-180);
                rand = Random.Range(min, max);
                GameObject.Find("GlassBox3").transform.position = new Vector3(16, 2, rand-280);
                rand = Random.Range(min, max);
                GameObject.Find("GlassBox4").transform.position = new Vector3(18, 2, rand-200);
        
                speedup++;
                x++;
                */
            }
            if (z==2){
   
               
                //GameObject.Find("Terrain").transform.position = new Vector3(0, 0, (256 * i-100));
                //GameObject.Find("SpikedTerrain").transform.position = new Vector3(-167, -220, 256 * i-100);
                //Generate random num with min and max
                int min = 256*x;
                int max = 256*x+256;

                int rand = Random.Range(min, max);
                /*
                GameObject.Find("Cube").transform.position = new Vector3(10, 2, rand-100 );
                rand = Random.Range(min, max);
                GameObject.Find("Cube1").transform.position = new Vector3(20, 2, rand-400);
                rand = Random.Range(min, max);
                GameObject.Find("Cube2").transform.position = new Vector3(11,2, rand-600);
                rand = Random.Range(min, max);
                GameObject.Find("Cube3").transform.position = new Vector3(10, 2, rand-150);
                rand = Random.Range(min, max);
                GameObject.Find("Cube4").transform.position = new Vector3(14, 2, rand-200);
                rand = Random.Range(min, max);
                GameObject.Find("Cube5").transform.position = new Vector3(19, 2, rand-250);
                rand = Random.Range(min, max);
                GameObject.Find("Cube6").transform.position = new Vector3(20, 2, rand-300);
                rand = Random.Range(min, max);
                GameObject.Find("Cube7").transform.position = new Vector3(30, 2, rand-350);
                 rand = Random.Range(min, max);
                 */
                 /*
                GameObject.Find("GlassBox1").transform.position = new Vector3(10, 2, rand-120);
                rand = Random.Range(min, max);
                GameObject.Find("GlassBox2").transform.position = new Vector3(20, 2, rand-180);
                rand = Random.Range(min, max);
                GameObject.Find("GlassBox3").transform.position = new Vector3(16, 2, rand-280);
                rand = Random.Range(min, max);
                GameObject.Find("GlassBox4").transform.position = new Vector3(18, 2, rand-200);
                rand = Random.Range(min, max);
                GameObject.Find("Magic Box").transform.position = new Vector3(10, 2, rand-120);
                speedup++;
                z=0;
                i++;
                x++;
                */
            }
            


            //Collider

            

        }
    
        


    }
}
