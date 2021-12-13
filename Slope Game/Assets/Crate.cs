
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


// This script is attached to the crate prefab.
// It is responsible for the crate's movement and destruction.

public class Crate : MonoBehaviour {
    public AudioClip audio;
   
    public GameObject cube;

    public AudioSource audioSource;

    public GameObject cracked;

    public int speed = 10;


    public int checker = 0;


    // This Coroutine is called when the ball collides with the magic box
    // It is used to determine if the ball is in special mode
    // This is because when the ball is moving at speed, the ball collides with the cracked crate and knocks the camera/ball out of line. 
    IEnumerator Special()
    {
        checker = 1;
        yield return new WaitForSeconds(5);
        checker =0;
       
    }
    void OnTriggerEnter(Collider other) {

        Debug.Log("Collision");
        if (other.gameObject.tag == "MagicBox")
        {
            StartCoroutine(Special());
        }
        
        if (other.gameObject.name == "Sphere") {
            // If the crate collides with the ball, and the ball is in magic mode, the carte is transformed to start of scene and audio is played
            if (checker == 1){
                float posx = cube.transform.position.x;
                float posz = cube.transform.position.z;
                float posy = cube.transform.position.y;
                
                cube.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                audioSource.clip = audio;
                audioSource.Play();
            }
            // If the crate collides with the ball, and the ball is not in magic mode, the crate is transformed to the start, a cracked crate is spawned infront and the audio is played
            else {
                float posx = cube.transform.position.x;
                float posz = cube.transform.position.z;
                float posy = cube.transform.position.y;
                
                // The cracked crate is spawned the speed distance infront of the crate to allow for the ball not to hit the carte
                cracked.transform.position = new Vector3(posx, posy, posz + speed +20);
                cube.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                audioSource.clip = audio;
                audioSource.Play();

            }

        }
       


    }
    void Start(){
        audioSource.volume = 0.5f;
        audioSource.clip = audio;
    }
    // The Update function is used to determine if the ball has sped up using the space key
        void Update(){

        if (Input.GetKeyDown(KeyCode.Space)){
           speed = speed + 10;
        }
    }
}