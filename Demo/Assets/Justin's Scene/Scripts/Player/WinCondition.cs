using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public Meter playerOneMeter;
    public Meter playerTwoMeter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerOneMeter.playerOneMeter >= 24)
        {
            SceneManager.LoadScene("Player 1 Winning Screen");
        }

        if(playerTwoMeter.playerTwoMeter >= 24)
        {
            SceneManager.LoadScene("Player 2 Winning Screen");
        }
    }
}
