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


// The volume will be initially set to 100%
 void Start() {
    slider.value = 1;
}

// As the slider value changes, the menu volume will change
void Update() {
    float vol = slider.value * 100;
    textvol.text = vol.ToString("0") + "%";
    source.volume = slider.value;
    source.loop = true;
}
}