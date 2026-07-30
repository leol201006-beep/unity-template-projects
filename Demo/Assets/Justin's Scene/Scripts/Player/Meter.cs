using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meter : MonoBehaviour
{
    public Rigidbody2D playerUno;
    public Rigidbody2D playerDos;

    public float speed;
    public int playerOneMeter = 0;
    public int playerTwoMeter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(playerOneMeter == 0 && playerTwoMeter == 0)
        {
            Debug.Log("");

            Vector3.MoveTowards(playerUno.position, new Vector3((playerUno.position.x + playerDos.position.x) / 2, playerUno.position.y, 0), speed);
            Vector3.MoveTowards(playerDos.position, new Vector3((playerDos.position.x + playerUno.position.x) / 2, playerDos.position.y, 0), speed);
            playerUno.transform.position = new Vector3(-0.38f,2.01f,0);
            playerDos.transform.position = new Vector3(-0.33f,-2.49f,0);
        }

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
    
    public void IncreaseOne()
    {
        playerOneMeter += 1;
        playerTwoMeter -= 1;
        playerUno.velocity = new Vector2(playerUno.velocity.x + 5.0f,0);
        playerDos.velocity = new Vector2(playerDos.velocity.x - 5.0f,0);
    }
    public void IncreaseTwo()
    {
        playerTwoMeter += 1;
        playerOneMeter -= 1;
        playerDos.velocity = new Vector2(playerDos.velocity.x + 5.0f,0);
        playerUno.velocity = new Vector2(playerUno.velocity.x - 5.0f,0);
    }
    
    public void BoostOne()
    {
        playerOneMeter += 4;
        playerTwoMeter -= 4;
        playerUno.velocity = new Vector2(playerUno.velocity.x + 20f,0);
        playerDos.velocity = new Vector2(playerDos.velocity.x - 20f,0);
    }
    public void BoostTwo()
    {
        playerTwoMeter += 4;
        playerOneMeter -= 4;
        playerDos.velocity = new Vector2(playerUno.velocity.x + 20f,0);
        playerUno.velocity = new Vector2(playerDos.velocity.x - 20f,0);
    }


}
