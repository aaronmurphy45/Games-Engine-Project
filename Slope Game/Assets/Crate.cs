
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Crate : MonoBehaviour {
    public AudioSource audio;
    //public GameObject Cube;
    public GameObject cube;

    void OnTriggerEnter(Collider other) {
        Debug.Log("Crate: OnTriggerEnter");
        Debug.Log(other.gameObject);
        //if (other.gameObject == cube) {
            Debug.Log("Crate: OnTriggerEnter: cube");
            cube.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            audio.Play();
            //score = score + 10;
        //}


    }
    void Start(){
        audio = GetComponent<AudioSource>();
    }
    void Update(){

    }
}