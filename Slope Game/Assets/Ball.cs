

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ball : MonoBehaviour {

  public Text scoreText;
  public int speed = 100;
  public float rotSpeed =30;
  public int i = 3;

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
  int z = 0;
 public int dif1 = 0;
 public int speedup = 1;
  AudioSource audioSource;
	void Start () {

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

        score = score + 1;
        //scoreText.text = "Score: " + score;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed = speed + 10;
        }
        Debug.Log(score);
        transform.position += Vector3.forward * Time.deltaTime * speed ;//* speedup;
        

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
        if (GameObject.Find("Sphere").transform.position.z>(256*i)-100){
            /*
            //Create a new terrain
            GameObject parent = (GameObject)Instantiate(new GameObject("Terrain"));
            parent.transform.position = new Vector3(0, 0, 256*i);

            TerrainData terrainData = new TerrainData();
            terrainData = GenerateTerrain(terrainData);
            Terrain terrain = Terrain.CreateTerrainGameObject(terrainData).GetComponent<Terrain>();
            terrain.transform.position = new Vector3(0, 0, 256*i);
            terrain.transform.parent = parent.transform;
            i++;
            */
            if (z == 0){
                GameObject.Find("Terrain2").transform.position = new Vector3(0, 0, 256 * i - 100);
                GameObject.Find("SpikedTerrain2").transform.position = new Vector3(-112, -200, 256 * i - 100);
                z++;
                i++;
                int min = 256*x;
                int max = 256*x+256;


                int rand = Random.Range(min, max);
                GameObject.Find("Cube").transform.position = new Vector3(10, 5, rand-21);
                rand = Random.Range(min, max);
                GameObject.Find("Cube1").transform.position = new Vector3(10, 5, rand- 80);
                rand = Random.Range(min, max);
                GameObject.Find("Cube2").transform.position = new Vector3(10, 5, rand-120);
                speedup++;
                x++;
            }
            if (z==1){
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


                GameObject.Find("Cube").transform.position = new Vector3(10, 5, rand);
                rand = Random.Range(min, max);
                GameObject.Find("Cube1").transform.position = new Vector3(10, 5, rand);
                rand = Random.Range(min, max);
                GameObject.Find("Cube2").transform.position = new Vector3(10, 5, rand);
                speedup++;
                x++;
            }
            if (z==2){
                GameObject.Find("Terrain").transform.position = new Vector3(0, 0, 256 * i -100);
                  GameObject.Find("SpikedTerrain").transform.position = new Vector3(-112, -200, 256 * i -100);
                //Generate random num with min and max
                int min = 256*x;
                int max = 256*x+140;

                int rand = Random.Range(min, max);
                GameObject.Find("Cube").transform.position = new Vector3(10, 5, rand );
                rand = Random.Range(min, max);
                GameObject.Find("Cube1").transform.position = new Vector3(20, 5, rand);
                rand = Random.Range(min, max);
                GameObject.Find("Cube2").transform.position = new Vector3(10, 5, rand);
                speedup++;
                z=0;
                i++;
                x++;
            }

            //Collider
            GameObject.Find("Cube").AddComponent<BoxCollider>();
            GameObject.Find("Cube1").AddComponent<BoxCollider>();
            GameObject.Find("Cube2").AddComponent<BoxCollider>();


            void OnCollisionEnter(Collison collision)
            {
                if (collision.gameObject.name == "Cube")
                {
                    Destroy(collision.gameObject);
                    score = score + 10;
                    audioSource.Play();
                    //scoreText.text = "Score: " + score;
                }
                if (collision.gameObject.name == "Cube1")
                {
                    Destroy(collision.gameObject);
                    score = score + 10;
                     audioSource.Play();
                    //scoreText.text = "Score: " + score;
                }
                if (collision.gameObject.name == "Cube2")
                {
                    Destroy(collision.gameObject);
                    audioSource.Play();
                    score = score + 10;
                    //scoreText.text = "Score: " + score;
                }
            }

            


            /*
            Collider.OnCollisionEnter();
              Collider.OnCollisionExit();
              Collider.OnCollisionStay();

              */


            if (GameObject.Find("Sphere").transform.position.y < -10)
            {
                // print Game Over
                Application.LoadLevel(Application.loadedLevel);

                speed = 0;
                Application.LoadLevel("GameOver");


            }


        }


    }
}
