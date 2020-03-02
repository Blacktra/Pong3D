using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercices : MonoBehaviour
{
    public int i; 

    // Update is called once per frame
    void Update()
    {
        if( i < 10)
        {
            Debug.Log("i menor a 10 - codigo 1");
        }
        else if( i > 10 && i < 20)
        {
            Debug.Log("i mayor a 10 y menor a 20 - codigo 2");
        }
        else if(i > 20) 
        {
            Debug.Log("i mayor a 20 - codigo 3");
        }
    }
}
