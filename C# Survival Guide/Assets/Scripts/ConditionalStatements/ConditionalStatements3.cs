using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalStatements3 : MonoBehaviour
{
    public int speed;
    public bool isPositive;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            speed+= 3;

            if (speed > 10)
            {
                Debug.Log("You have to slow down");
            }

        }
        
        if(Input.GetKeyDown(KeyCode.S))
        {
            speed-= 3;

            if (speed == 0 || speed < 0)
            {
                speed = 0;
                isPositive = true;
                Debug.Log("You have to speed up");
            }


        }
       
    }
}
