
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Crate : MonoBehaviour {
    public AudioClip audio;
    //public GameObject Cube;
    public GameObject cube;

    public AudioSource audioSource;

    public GameObject cracked;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Sphere") {
            Debug.Log("Crate: OnTriggerEnter: cube");
            cracked.transform.position = cube.transform.position;
            cube.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            audioSource.clip = audio;
            audioSource.Play();
            //score = score + 10;
        }


    }
    void Start(){
        //audio = Resources.Load<AudioClip>("66772__kevinkace__barrel-break-4");
        audioSource.clip = audio;
    }
    void Update(){

    }
}