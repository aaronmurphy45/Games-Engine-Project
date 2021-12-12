using UnityEngine;

public class MagicBoxGeneration : MonoBehaviour {
    public GameObject cube;
    public GameObject sphere;
    int i =1;
    

        private void Update() {
            if (sphere.transform.position.z > (256*i)-30) {
                int min = 5, max = 25;
                int randx = Random.Range(min, max);
                min = 256*i;
                max = 256*i + 256;
                int randz = Random.Range(min, max);
                cube.transform.position = new Vector3(randx, 2, randz);
                i=i+5;
            }
            
        }
}