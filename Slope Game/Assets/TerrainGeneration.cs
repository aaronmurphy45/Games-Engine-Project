
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

    public GameObject sphere;
    public GameObject terrain;
    public GameObject spikedTerrain;

    
    

    public TerrainGeneration(){
        void Start(){
        }
    }
    void Update(){
            if (sphere.transform.position.z > (256*i)-100){
                    terrain.transform.position = new Vector3(0, 0, 256 * i - 100);
                    spikedTerrain.transform.position = new Vector3(-167, -220, 256 * i);
                    i = i +3;
                }
        }
        
}
