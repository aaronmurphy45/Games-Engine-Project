using UnityEngine;

public class MovingCrate : MonoBehaviour {
    public GameObject crate;
    public int speed = 10;
    public AudioClip audio;
    public AudioSource audioSource;

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

        float newposx = Mathf.PingPong(Time.time * speed, 10);

        crate.transform.position = new Vector3(newposx, 2, posz);
        //crate.transform.position = Vector3.MoveTowards(crate.transform.position, new Vector3(crate.transform.position.x, crate.transform.position.y, crate.transform.position.z), speed * Time.deltaTime);
        


   }
}