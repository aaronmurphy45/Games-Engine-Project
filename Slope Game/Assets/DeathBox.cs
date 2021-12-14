
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


// This script is attached to the crate prefab.
// It is responsible for the crate's movement and destruction.

public class DeathBox : MonoBehaviour {
    public AudioClip audio;
   
    public GameObject cube;

    public AudioSource audioSource;
    public int speed = 10;

    public bool checker = false;

    public int prevspeed=0;


    // This Coroutine is called when the ball collides with the magic box
    // It is used to determine if the ball is in special mode
    // This is because when the ball is moving at speed, the ball collides with the cracked crate and knocks the camera/ball out of line. 
    IEnumerator Special()
    {   
        prevspeed = speed;
        checker = true;
        yield return new WaitForSeconds(5);
        checker = false;
        speed = prevspeed;
       
    }
    void OnTriggerEnter(Collider other) {

         if (other.gameObject.name == "Magic Box")
            {
                Debug.Log("MAGIXC");
                StartCoroutine(Special());
               
            }

        Debug.Log(checker);
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Sphere") {
            // If the crate collides with the ball, and the ball is in magic mode, the carte is transformed to start of scene and audio is played
                cube.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                //audioSource.clip = audio;
                //audioSource.Play();
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