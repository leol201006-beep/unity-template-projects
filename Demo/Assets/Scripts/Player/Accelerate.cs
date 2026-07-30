using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerate : MonoBehaviour
{
    public Meter playeronemeter;
    public Meter playertwometer;
    public int gasOne = 0;
    public int gasTwo = 0;
    public Meter meter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) {
            gasOne += 1;
            Debug.Log("Gas1 + 1");
            meter.IncreaseOne();

            if(playeronemeter.playerOneMeter <= -10)
            {
                meter.BoostOne();
            }
        }

        if (Input.GetKeyDown(KeyCode.U)) {
            gasTwo += 1;
            Debug.Log("Gas2 + 1");
            meter.IncreaseTwo();

            if(playertwometer.playerTwoMeter <= -10)
            {
                meter.BoostTwo();
            }
        }
        
    }
}
