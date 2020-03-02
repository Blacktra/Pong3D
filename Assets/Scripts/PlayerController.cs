using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

          public float num1 = 0.7f;
          public float num2 = 3.37f;

    private void Awake() 
    {
        float num3 = num1 + num2;
        Debug.Log("Vale: " + num3);
    }
 

    // Start is called before the first frame update
    void Start()
    {
        //num3 = num1 + num2;
        //Debug.Log("Segundo en ejecutarse");
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(mousePos.y, -0.55f, 15f), transform.position.z);
    }
}
