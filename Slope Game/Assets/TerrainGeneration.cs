
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TerrainGeneration : MonoBehaviour
{

    public int width = 256;
    public int height = 256;
    public float scale = 20f;   
    public float offsetX = 100f;
    public float offsetY = 100f;
    public float offsetZ = 100f;
    public int i = 1;
    public int z = 0;

    public TerrainGeneration(){
        void Start(){
        }
    }
    void Update(){
            if (GameObject.Find("Sphere").transform.position.z > (256*i)-100){
                if (z==0){
                    GameObject.Find("Terrain2").transform.position = new Vector3(0, 0, 256 * i - 100);
                    GameObject.Find("SpikedTerrain2").transform.position = new Vector3(-167, -220, 256 * i - 100);
                    z++;
                    i++;
                }
                if (z==1){
                    GameObject.Find("Terrain1").transform.position = new Vector3(0, 0, 256 * i - 100);
                    GameObject.Find("SpikedTerrain1").transform.position = new Vector3(-167, -220, 256 * i - 100);
                    z++;
                    i++;
                }
                if (z==2){
                    GameObject.Find("Terrain").transform.position = new Vector3(0, 0, 256 * i - 100);
                    GameObject.Find("SpikedTerrain").transform.position = new Vector3(-167, -220, 256 * i - 100);
                    z++;
                    i++;
                }
        }
        
    }
}