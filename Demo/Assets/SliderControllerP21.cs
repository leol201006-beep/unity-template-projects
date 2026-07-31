using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderController2 : MonoBehaviour
{
    public GearChangeP2 gchange2;

    public Text valueText;
    int progress = 0;
    public Slider slider;

    void Update()
    {
        if (gchange2.press_two)
        
        {
            if(Input.GetKeyDown(KeyCode.O)){
                slider.value += 1;
                Debug.Log("lineran");
            }
        }
    }


    //display text value but we dont need that now
    public void OnSliderChanged2(int value){
        valueText.text = value.ToString();
    }

    public void UpdateProgress(){
        progress++;
        slider.value = progress;
    }
}
