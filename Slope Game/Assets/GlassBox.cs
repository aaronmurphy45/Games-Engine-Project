
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GlassBox : MonoBehaviour {

    // This script is used to make the glass box appear and disappear.
    public AudioClip glassSound;
    public AudioSource audioSource;
    public GameObject glass;

    public int checker = 0;


    // When the ball collides with the sphere the glassbox is transformed away and the sound is played.
       private void OnTriggerEnter(Collider other) {
        if (other.name == "Sphere") {
            glass.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            audioSource.clip = glassSound;
            audioSource.Play();
        }
    }
    private void Start() {
       audioSource.clip = glassSound;
       audioSource.volume = 0.5f;
        
    }
    private void Update() {
        
    }
}