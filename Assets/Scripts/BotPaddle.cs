using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotPaddle : MonoBehaviour
{
    public Transform ball;
    public float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        if (ball.GetComponent<BowlBehaviour>().gameStarted)
       {
        {
        if(transform.position.y<ball.position.y)
          {
           transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y +speed, -8.15f, 6.84f), transform.position.z);
          }else if (transform.position.y > ball.position.y)
          {
             transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y -speed, -8.15f, 6.84f), transform.position.z); 
          }
        }
       }
    }
}
