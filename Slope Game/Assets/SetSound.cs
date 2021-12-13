using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

// This script is used to set the sound volume using the slider in the Options menu.

public class SetSound : MonoBehaviour {
    
    public AudioSource source;
    
    public Slider slider;
    public TMP_Text textvol;

 void Start() {
    slider.value = 1;
}
void Update() {
    textvol.text = slider.value.ToString();
    source.volume = slider.value;
    source.loop = true;
}
}