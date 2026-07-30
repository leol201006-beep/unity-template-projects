using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderController : MonoBehaviour
{
    public Text valueText;
    int progress = 0;
    public Slider slider;


    //display text value but we dont need that now
    public void OnSliderChanged(int value){
        valueText.text = value.ToString();
    }

    public void UpdateProgress(){
        progress++;
        slider.value = progress;
    }
}
