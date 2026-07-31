using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GearChange : MonoBehaviour

{
    public Accelerate gasOne;
    public Meter playerOneMeter;
    public Accelerate gears;
    public Meter m;
    public GameObject switchgearone;
    public bool press_one = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if  (gears.gasOne == 30){
            switchgearone.SetActive(true);
            press_one = true;
            m.playerOneMeter = m.playerOneMeter * 1.02f;
        }

        else if (gears.gasOne == 60){
            switchgearone.SetActive(true);
            press_one = true;
            m.playerOneMeter = m.playerOneMeter * 1.04f;
        }

        else if (gears.gasOne == 90){
            switchgearone.SetActive(true);
            press_one = true;
            m.playerOneMeter = m.playerOneMeter * 1.06f;
        }

        else if (gears.gasOne == 120){
            switchgearone.SetActive(true);
            press_one = true;
            m.playerOneMeter = m.playerOneMeter * 1.08f;
        }

        else if (gears.gasOne == 150 || gears.gasOne > 150){
            switchgearone.SetActive(true);
            press_one = true;
            m.playerOneMeter = m.playerOneMeter * 1.1f;
        }
        
        else {
            switchgearone.SetActive(false);
        }
    }
}
