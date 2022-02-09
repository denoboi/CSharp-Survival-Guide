using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{

    public float defaultSpeed = 0;
    public float maxSpeed;
    private float delay = 1;

    void Start()
    {
        maxSpeed = defaultSpeed;
        maxSpeed = Random.Range(60, 120);
        StartCoroutine(SpeedIncrement());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator SpeedIncrement()
    {
        while(true)
        {
            yield return new WaitForSeconds(delay);
            defaultSpeed += 5;

            if (defaultSpeed > maxSpeed)
                break;
        }
    }



    IEnumerator LoopRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("Bam");
        }
             
    }


   
}
