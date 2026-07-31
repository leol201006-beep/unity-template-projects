using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GearChangeP2 : MonoBehaviour

{
    public Accelerate gasTwo;
    public Meter playerTwoMeter;
    public Accelerate gears;
    public Meter m;
    public GameObject switchgeartwo;
    public bool press_two = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if  (gears.gasTwo == 30){
            switchgeartwo.SetActive(true);
            press_two = true;
            m.playerTwoMeter = m.playerTwoMeter * 1.02f;
        }

        else if (gears.gasTwo == 60){
            switchgeartwo.SetActive(true);
            press_two = true;
            m.playerTwoMeter = m.playerTwoMeter * 1.04f;
        }

        else if (gears.gasTwo == 90){
            switchgeartwo.SetActive(true);
            press_two = true;
            m.playerTwoMeter = m.playerTwoMeter * 1.06f;
        }

        else if (gears.gasTwo == 120){
            switchgeartwo.SetActive(true);
            press_two = true;
            m.playerTwoMeter = m.playerTwoMeter * 1.08f;
        }

        else if (gears.gasTwo == 150 || gears.gasTwo > 150){
            switchgeartwo.SetActive(true);
            press_two = true;
            m.playerTwoMeter = m.playerTwoMeter * 1.1f;
        }
        
        else {
            switchgeartwo.SetActive(false);
            press_two = false;
        }
    }
}
