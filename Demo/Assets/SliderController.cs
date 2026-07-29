using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderControllertwo : MonoBehaviour
{
    public Text valueText;
    int progresstwo = 0;
    public Slider slider;


    //display text value but we dont need that now
    public void OnSliderChanged(int value){
        valueText.text = value.ToString();
    }

    public void UpdateProgresstwo(){
        progresstwo++;
        slider.value = progresstwo;
    }
}
