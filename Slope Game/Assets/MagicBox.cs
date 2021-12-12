
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class MagicBox : MonoBehaviour {
    
IEnumerator SpecialEffect(){
     
     Material mat = Resources.Load("Special", typeof(Material)) as Material;
        GameObject.Find("Sphere").GetComponent<MeshRenderer> ().material = mat;
        //score = score + 10;
        GameObject.Find("Magic Box").transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        //speed = 150;
        //checker = 1;
        yield return new WaitForSecondsRealtime(5);
        //speed = 10;
        //checker = 0;
        GameObject.Find("Sphere").GetComponent<MeshRenderer> ().material = Resources.Load("DefBall", typeof(Material)) as Material;
}
private void OnTriggerEnter(Collider other) {
    if (other.gameObject.tag == "MagicBox") {
       StartCoroutine(SpecialEffect());
    }
}
void Start () {
    //score = 0;

}
void Update() {
    
}
}
