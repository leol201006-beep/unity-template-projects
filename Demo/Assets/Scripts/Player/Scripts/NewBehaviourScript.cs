using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int gas = 0;
    public int gear = 1;




    // Start is called before the first frame update
    void Start()
    {
        if (gas == 30){
            gear += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
