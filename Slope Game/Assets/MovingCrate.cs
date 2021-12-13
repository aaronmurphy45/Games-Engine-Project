using UnityEngine;

public class MovingCrate : MonoBehaviour {
    public GameObject crate;
    public float speed = 10;
    public AudioClip audio;
    public AudioSource audioSource;

    public bool going_right = false;

   void OnTriggerEnter(Collider other) {

        
        
        if (other.gameObject.name == "Sphere") {
          
                float posx = crate.transform.position.x;
                float posz = crate.transform.position.z;
                float posy = crate.transform.position.y;

                //cracked.transform.position = new Vector3(posx, posy, posz + 20);
                crate.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                audioSource.clip = audio;
                audioSource.Play();


            
            //score = score + 10;

        }
       


    }
   void Update() {
       
       //move crate bewteen 2 points 

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


        if (posx > 20) {
            going_right = false;
        }
        else if (posx < 0) {
            going_right = true;
        }





/*
        if (posx <= 0) {
            Debug.Log("going right");
            going_right = false;
        }
        if (posx >= 30) {
            Debug.Log("here");
            going_right = true;
        }

*/
        
        // 460 left

        //490 right
       
        //crate.transform.position = Vector3.MoveTowards(crate.transform.position, new Vector3(crate.transform.position.x, crate.transform.position.y, crate.transform.position.z), speed * Time.deltaTime);
        


   }
}