using UnityEngine;

public class Crate : MonoBehaviour {
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Cube") {
            GameObject.Find("Cube").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            audio.Play();
            score = score + 10;
        }
        if (other.gameObject.name == "Cube1") {
            GameObject.Find("Cube1").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            audio.Play();
            score = score + 10;
        }
        if (other.gameObject.name == "Cube2") {
            GameObject.Find("Cube2").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            audio.Play();
            score = score + 10;
        }
        if (other.gameObject.name == "Cube3") {
            GameObject.Find("Cube3").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            audio.Play();
            score = score + 10;
        }
        if (other.gameObject.name == "Cube4") {
            GameObject.Find("Cube4").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            audio.Play();
            score = score + 10;
        }
        if (other.gameObject.name == "Cube5") {
            GameObject.Find("Cube5").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            audio.Play();
            score = score + 10;
        }
        if (other.gameObject.name == "Cube6") {
            GameObject.Find("Cube6").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            audio.Play();
            score = score + 10;
        }
        

    }
    void Start(){
        audio = GetComponent<AudioSource>();
    }
    void Update(){

    }
}