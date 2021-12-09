
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GlassBox : MonoBehaviour {

    
    public AudioClip glassSound;
    public AudioSource audioSource;
    public GameObject glass;

    private void OnTriggerEnter(Collider other) {
        Debug.Log("GlassBox: OnTriggerEnter");
        Debug.Log(other.name);
       //Debug.Log("GlassBox: other.tag = " + other.gameObject.tag);
        if (other.name == "Sphere") {
            /*
            if (checker==1){
                        score = score + 10;
                    }
                    else{
                        score = score - 50;
                    }
                    */
                    
                    glass.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                    audioSource.clip = glassSound;
                    audioSource.Play();
        }
    }
    private void Start() {
       audioSource.clip = glassSound;
        
    }
    private void Update() {
        
    }
}