using UnityEngine;

public class MovingCrate : MonoBehaviour {
    public GameObject crate;
    public float speed = 10;
    public AudioClip audio;
    public AudioSource audioSource;

    public bool going_right = false;

    // This script is used to move the moving crate and also to play the sound effect and make the crate disappear when the crate is hit

   void OnTriggerEnter(Collider other) {

        
        // If the crate hits the player, the crate disappears and the sound effect is played
        if (other.gameObject.name == "Sphere") {
          
                float posx = crate.transform.position.x;
                float posz = crate.transform.position.z;
                float posy = crate.transform.position.y;

                crate.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                audioSource.clip = audio;
                audioSource.Play();


            
            //score = score + 10;

        }
       


    }
    void Start(){
        audioSource.volume = 0.5f;
    }
   void Update() {
       
       //move crate bewteen 2 points 
        //get crate position
        float posx = crate.transform.position.x;
        float posz = crate.transform.position.z;
        float posy = crate.transform.position.y;

        //float newposx = Mathf.PingPong(Time.time* speed , 30);       
           
        
        //Move crate on terrain 
        if (going_right) {
            crate.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        else {
            crate.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        // if crate reaches end of plaform it will go the other way
        if (posx > 20) {
            going_right = false;
        }
        else if (posx < 0) {
            going_right = true;
        }


   }
}