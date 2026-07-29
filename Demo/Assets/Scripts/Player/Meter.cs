using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meter : MonoBehaviour
{
    public Rigidbody2D playerUno;
    public Rigidbody2D playerDos;

    public int playerOneMeter;
    public int playerTwoMeter;
    public int playerTranslate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* if(playerUno.velocity.x > 0)
        {
            playerUno.velocity = new Vector2(playerUno.velocity.x - 0.1f,0);
        }
        if(playerUno.velocity.x < 0)
        {
            playerUno.velocity = new Vector2(playerUno.velocity.x + 0.1f,0);
        }
        if(playerDos.velocity.x > 0)
        {
            playerDos.velocity = new Vector2(playerDos.velocity.x - 0.1f,0);
        }
        if(playerDos.velocity.x < 0)
        {
            playerDos.velocity = new Vector2(playerDos.velocity.x + 0.1f,0);
        } */
    }
    
    public void IncreaseOne(){
        playerOneMeter += 1;
        playerTwoMeter -= 1;
        playerUno.velocity = new Vector2(playerUno.velocity.x + 5.0f,0);
        playerDos.velocity = new Vector2(playerDos.velocity.x - 5.0f,0);
    }
    public void IncreaseTwo(){
        playerOneMeter -= 1;
        playerTwoMeter += 1;
        playerDos.velocity = new Vector2(playerDos.velocity.x + 5.0f,0);
        playerUno.velocity = new Vector2(playerUno.velocity.x - 5.0f,0);
    }
}
