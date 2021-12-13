
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// This script is used to generate the terrain and the spiked terrain underneath it.
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
        //  // The length of each terrain is 256. 
            // As the ball moves forward, the terrain and the spiked terrain will be generated exactly 256 blocks from the previous terrain.
            if (sphere.transform.position.z > (256*i)-256){
                    terrain.transform.position = new Vector3(0, 0, 256 * i - 100);
                    spikedTerrain.transform.position = new Vector3(-167, -220, 256 * i);
                    // i + 3 as there are 3 different terrains which are intermittently generated.
                    i = i +3;
                }
        }
        
}
