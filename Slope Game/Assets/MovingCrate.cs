using UnityEngine;

public class MovingCrate : MonoBehaviour {
    public GameObject crate;
    public float speed = 0.1f;
    public AudioClip audio;
    public AudioSource audioSource;

    public bool going_right = false;

   void OnTriggerEnter(Collider other) {

        Debug.Log("Collision");
        
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

        //float newposx = Mathf.PingPong(Time.time* speed , 30);
        while (crate.transform.position.x > 30) {
            crate.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        

        if(going_right) 
        {
            crate.transform.Translate(Vector3.right * Time.deltaTime * speed); // Move right
            if(crate.transform.position.x > 5) // Too far right
            { 
                going_right = false; // Switch direction
            }
        }
        else 
        {
            crate.transform.Translate(-Vector3.right * Time.deltaTime * speed); // Move left
            if(crate.transform.position.x < -5) // Too far left
            { 
                going_right = true; // Switch direction
            }
        }

       
        //crate.transform.position = Vector3.MoveTowards(crate.transform.position, new Vector3(crate.transform.position.x, crate.transform.position.y, crate.transform.position.z), speed * Time.deltaTime);
        


   }
}