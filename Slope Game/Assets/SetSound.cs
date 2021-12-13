using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;




public class SetSound : MonoBehaviour {
    
    public AudioSource source;
    
    public Slider slider;
    public TMP_Text textvol;

 void Start() {
    
}
void Update() {
    textvol.text = slider.value.ToString();
    source.volume = slider.value;
    source.loop = true;
}
}