using UnityEngine;

public class GlassBoxGeneration : MonoBehaviour {
    public GameObject cube;
    public GameObject sphere;
    int i =1;
    
    // This script is used to procedurally generate a glass box.
        private void Update() {
             // The length of each terrain is 256. 
            // As the ball moves forward, the glassboxes will be generated in a random position in bewteen that multiple of the length of the terrain.
            if (sphere.transform.position.z > (256*i)-30) {
                // Randomize x positon of the cube between 5 and 25 
                int min = 5, max = 25;
                int randx = Random.Range(min, max);
                // Randomize z positon of the cube between 256 i and 256 i + 256
                min = 256*i;
                max = 256*i + 256;
                int randz = Random.Range(min, max);
                cube.transform.position = new Vector3(randx, 2, randz);
                i++;
            }
            
        }


    
}
    
        

