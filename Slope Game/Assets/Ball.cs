

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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

 public Text MyText;

 AudioSource audio;
 AudioSource audio2;
   
     IEnumerator SpecialEffect(){
        Material mat = Resources.Load("Special", typeof(Material)) as Material;
        Debug.Log(mat);
        GameObject.Find("Sphere").GetComponent<MeshRenderer> ().material = mat;
        score = score + 10;
        GameObject.Find("Magic Box").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        speed = 150;
        yield return new WaitForSecondsRealtime(5);
        speed = 100;
        GameObject.Find("Sphere").GetComponent<MeshRenderer> ().material = Resources.Load("Default", typeof(Material)) as Material;
        
     }
     void OnTriggerEnter(Collider other) {
              Debug.Log("COLLIDED");
                if (other.gameObject.name == "Cube")
                {
                    //Destroy(other.gameObject);
                    score = score + 10;
                    GameObject.Find("Cube").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                    audio.Play();
                    //scoreText.text = "Score: " + score;
                }
                if (other.gameObject.name == "Cube1")
                {
                    //Destroy(other.gameObject);
                    score = score + 10;
                    GameObject.Find("Cube1").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                     audio.Play();
                    //scoreText.text = "Score: " + score;
                }
                if (other.gameObject.name == "Cube2")
                {
                    //Destroy(other.gameObject);
                    
                    GameObject.Find("Cube2").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                    audio.Play();
                    score = score + 10;
                    
                    //scoreText.text = "Score: " + score;
                }
                if (other.gameObject.name == "Cube3")
                {
                    //Destroy(other.gameObject);
                    score = score + 10;
                    GameObject.Find("Cube3").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                    audio.Play();
                    //scoreText.text = "Score: " + score;
                }
                if (other.gameObject.name == "Cube4")
                {
                    //Destroy(other.gameObject);
                    score = score + 10;
                    GameObject.Find("Cube4").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                    audio.Play();
                    //scoreText.text = "Score: " + score;
                }
                if (other.gameObject.name == "Cube5")
                {
                    //Destroy(other.gameObject);
                    score = score + 10;
                    GameObject.Find("Cube5").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                    audio.Play();
                    //scoreText.text = "Score: " + score;
                }
                if (other.gameObject.name == "Cube6")
                {
                    //Destroy(other.gameObject);
                    score = score + 10;
                    GameObject.Find("Cube6").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                    audio.Play();
                    //scoreText.text = "Score: " + score;
                }
                if (other.gameObject.name == "Cube7")
                {
                    //Destroy(other.gameObject);
                    score = score + 10;
                    GameObject.Find("Cube7").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                    audio.Play();
                    //scoreText.text = "Score: " + score;
                }
                if (other.gameObject.name == "Magic Box")
                {
                    //Destroy(other.gameObject);
                    //Assets/Ball.cs(109,56): error CS1061: 'Component' does not contain a definition for 'material' and no accessible extension method 'material' accepting a first argument of type 'Component' could be found (are you missing a using directive or an assembly reference?)

                    //score = score + 10;

                    StartCoroutine(SpecialEffect());
                    //scoreText.text = "Score: " + score;

                }
                   
                

            }


	void Start () {
        /*
        audio2 = GetComponent<AudioSource>();
        audio2.Play();
        audio2.loop = true;*/
        audio = GameObject.FindObjectOfType<AudioSource>();
        //audio = GetComponent<AudioSource>();
        audio2 = GameObject.Find("song").GetComponent<AudioSource>();
        audio2.Play();
        audio2.loop = true;
        
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
        GameObject.Find("Text").GetComponent<Text>().text = "Score: " + score;
        //score = score + 1;
        //scoreText.text = "Score: " + score;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed = speed + 10;
        }
        Debug.Log(score);
        if (score > 1000*i)
        {
            speed = speed + 10;
            
        }





       
        transform.position += Vector3.forward * Time.deltaTime * speed ;//* speedup;
        //GameObject.Find("Sphere").transform.Rotate(Vector3.forward, rotSpeed * Time.deltaTime);
        //GameObject.Find("Sphere").transform.Rotate(Vector3.right, rotSpeed * Time.deltaTime);

        //Detect if the left mouse button is pressed
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Move object across XY plane
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            //transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0);
            //transform.Translate(0,0, Input.GetAxis("Verical") * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Move object across XY plane
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            //transform.Rotate(0, Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0);
            //transform.Translate(0,0, Input.GetAxis("Verical") * speed * Time.deltaTime);
        }
        if (GameObject.Find("Sphere").transform.position.z>(256*i -100)) {
            Debug.Log("hi");
            //transform.position += Vector3.forward * Time.deltaTime * speed ;//* speedup;
            if (z == 0){
                Debug.Log("hi2");
                GameObject.Find("Terrain2").transform.position = new Vector3(0, 0, 256 * i - 100);
                GameObject.Find("SpikedTerrain2").transform.position = new Vector3(-112, -200, 256 * i - 100);
                z++;
                i++;
                int min = 256*x;
                int max = 256*x+256;


                int rand = Random.Range(min, max);
                GameObject.Find("Cube").transform.position = new Vector3(10, 2, rand-100);
                rand = Random.Range(min, max);
                GameObject.Find("Cube1").transform.position = new Vector3(10, 2, rand- 80);
                rand = Random.Range(min, max);
                GameObject.Find("Cube2").transform.position = new Vector3(10, 2, rand-120);
                rand = Random.Range(min, max);
                GameObject.Find("Cube3").transform.position = new Vector3(10, 2, rand-140);
                rand = Random.Range(min, max);
                GameObject.Find("Cube4").transform.position = new Vector3(10, 2, rand-160);
                rand = Random.Range(min, max);
                GameObject.Find("Cube5").transform.position = new Vector3(10, 2, rand-180);
                rand = Random.Range(min, max);
                GameObject.Find("Cube6").transform.position = new Vector3(10, 2, rand-200);
                rand = Random.Range(min, max);
                GameObject.Find("Cube7").transform.position = new Vector3(10, 2, rand-220);
                speedup++;
                x++;
            }
            if (z==1){
                Debug.Log("hi3");
                GameObject.Find("Terrain1").transform.position = new Vector3(0, 0, 256 * i - 100);
                GameObject.Find("SpikedTerrain1").transform.position = new Vector3(-112, -200, 256 * i -100);
                GameObject.Find("TunnelRight").transform.position = new Vector3(29, 5, 256 * i - 100);
                GameObject.Find("TunnelLeft").transform.position = new Vector3(3, 5, 256 * i - 100);
                GameObject.Find("TunnelTop").transform.position = new Vector3(15, 10, 256 * i - 100);

                z++;
                i++;
                int min = 256*x;
                int max = 256*x+256;
                int rand = Random.Range(min, max);


                GameObject.Find("Cube").transform.position = new Vector3(10, 2, rand-100);
                rand = Random.Range(min, max);
                GameObject.Find("Cube1").transform.position = new Vector3(10, 2, rand-100);
                rand = Random.Range(min, max);
                GameObject.Find("Cube2").transform.position = new Vector3(10, 2, rand-100);
                rand = Random.Range(min, max);
                GameObject.Find("Cube3").transform.position = new Vector3(10, 2, rand-150);
                rand = Random.Range(min, max);
                GameObject.Find("Cube4").transform.position = new Vector3(10, 2, rand-200);
                rand = Random.Range(min, max);
                GameObject.Find("Cube5").transform.position = new Vector3(10, 2, rand-250);
                rand = Random.Range(min, max);
                GameObject.Find("Cube6").transform.position = new Vector3(10, 2, rand-300);
                rand = Random.Range(min, max);
                GameObject.Find("Cube7").transform.position = new Vector3(10, 2, rand-350);
            
                speedup++;
                x++;
            }
            if (z==2){
                Debug.Log("hi4");
                GameObject.Find("Terrain").transform.position = new Vector3(0, 0, (256 * i-100));
                GameObject.Find("SpikedTerrain").transform.position = new Vector3(-112, -200, 256 * i-100);
                //Generate random num with min and max
                int min = 256*x;
                int max = 256*x+256;

                int rand = Random.Range(min, max);
                GameObject.Find("Cube").transform.position = new Vector3(10, 2, rand-100 );
                rand = Random.Range(min, max);
                GameObject.Find("Cube1").transform.position = new Vector3(20, 2, rand-100);
                rand = Random.Range(min, max);
                GameObject.Find("Cube2").transform.position = new Vector3(10,2, rand-100);
                rand = Random.Range(min, max);
                GameObject.Find("Cube3").transform.position = new Vector3(10, 2, rand-150);
                rand = Random.Range(min, max);
                GameObject.Find("Cube4").transform.position = new Vector3(10, 2, rand-200);
                rand = Random.Range(min, max);
                GameObject.Find("Cube5").transform.position = new Vector3(10, 2, rand-250);
                rand = Random.Range(min, max);
                GameObject.Find("Cube6").transform.position = new Vector3(10, 2, rand-300);
                rand = Random.Range(min, max);
                GameObject.Find("Cube7").transform.position = new Vector3(10, 2, rand-350);
                speedup++;
                z=0;
                i++;
                x++;
            }


            //Collider

          
            
    /*
            if (GameObject.Find("Sphere").transform.position.y <(-100));
            {
                // print Game Over
                Debug.Log("Game Over");
                Application.LoadLevel(Application.loadedLevel);

                speed = 0;
                Application.LoadLevel("GameOver");


            }
        */


        }


    }
}
