
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Crate : MonoBehaviour {
    public AudioClip audio;
    //public GameObject Cube;
    public GameObject cube;

    public AudioSource audioSource;

    public GameObject cracked;

    public int speed = 10;


    public int checker = 0;
    IEnumerator Special()
    {
        checker = 1;
        yield return new WaitForSeconds(5);
        checker =0;
       
    }
    void OnTriggerEnter(Collider other) {
        Debug.Log(other.gameObject.name);
        
        if (other.gameObject.name == "Sphere") {

            float posx = cube.transform.position.x;
            float posz = cube.transform.position.z;
            float posy = cube.transform.position.y;

            cube.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            audioSource.clip = audio;
            audioSource.Play();
            //score = score + 10;

        }
        //if (GameObject.Find("Camera").)


    }
    void Start(){
        //audio = Resources.Load<AudioClip>("66772__kevinkace__barrel-break-4");
        audioSource.clip = audio;
    }
    void Update(){

        if (Input.GetKeyDown(KeyCode.Space)){
           speed = speed + 10;
        }
    }
}