using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public ParticleSystem particle;
    public int limitcount;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        //particle = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other){ 
    if (other.gameObject.CompareTag("Ball"))
    {
        count++;
        if (count >= limitcount)
        count = 0;
            particle.Play();

        Destroy(this.gameObject);
    }
        
    }
}
