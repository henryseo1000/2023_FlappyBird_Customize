using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Slider sound_slider;

    public void OnMuteCheck(bool isOn){
        if(isOn){
            sound_slider.value = 0;
        }

        GetComponent<AudioSource>().volume = sound_slider.value;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
