using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meter : MonoBehaviour
{
    public int playerOneMeter;
    public int playerTwoMeter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    public void IncreaseOne(){
        playerOneMeter += 1;
        playerTwoMeter -= 1;
    }
    public void IncreaseTwo(){
        playerOneMeter -= 1;
        playerTwoMeter += 1;
    }
}
