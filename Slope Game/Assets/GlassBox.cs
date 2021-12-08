
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GlassBox : MonoBehaviour {

    AudioSource audio;
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "GlassBox1") {
            /*
            if (checker==1){
                        score = score + 10;
                    }
                    else{
                        score = score - 50;
                    }
                    */
                    
                    GameObject.Find("GlassBox1").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                    audio.Play();
        }
        if (other.gameObject.tag == "GlassBox2") {
            /*
            if (checker==2){
                        score = score + 10;
                    }
                    else{
                        score = score - 50;
                    }
                    */
                    
                    GameObject.Find("GlassBox2").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                    audio.Play();
        }
        if (other.gameObject.tag == "GlassBox3") {
            /*
            if (checker==3){
                        score = score + 10;
                    }
                    else{
                        score = score - 50;
                    }
                    */
                    
                    GameObject.Find("GlassBox3").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                    audio.Play();
        }
        if (other.gameObject.tag == "GlassBox4") {
            /*
            if (checker==4){
                        score = score + 10;
                    }
                    else{
                        score = score - 50;
                    }
                    */
                    GameObject.Find("GlassBox4").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                    audio.Play();
        }
    }
    private void Start() {
        
    }
    private void Update() {
        
    }
}