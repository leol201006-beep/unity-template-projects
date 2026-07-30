using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GearChange : MonoBehaviour

{
    public Accelerate gasOne;
    public Meter playerOneMeter;
    public Accelerate gears;
    public Meter m;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if  (gears.gasOne == 30 && gears.gasOne < 60){
            //display code goes here:
            m.playerOneMeter = m.playerOneMeter * 1.2f;
        }

        else if (gears.gasOne == 60 && gears.gasOne < 90){
            //display code goes here:
            m.playerOneMeter = m.playerOneMeter * 1.4f;
        }

        else if (gears.gasOne == 90 && gears.gasOne < 120){
            //display code goes here:
            m.playerOneMeter = m.playerOneMeter * 1.6f;
        }

        else if (gears.gasOne == 120 && gears.gasOne < 150){
            //display code goes here:
            m.playerOneMeter = m.playerOneMeter * 1.8f;
        }

        else if (gears.gasOne == 150 || gears.gasOne > 150){
            //display code goes here:
            m.playerOneMeter = m.playerOneMeter * 2.0f;
        }
        
    }
}
