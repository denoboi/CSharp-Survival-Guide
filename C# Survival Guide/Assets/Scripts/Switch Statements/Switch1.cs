using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch1 : MonoBehaviour
{
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (points == 50)
        //{
        //    Debug.Log("Points are 50");

        //}

        //else if(points == 100)
        //{
        //    Debug.Log("Points are 100");
        //}

        //else
        //{
        //    Debug.Log("You need 50 or 100 pts to receive a message");
        //}


        switch(points)

        {
            case 50: 
                Debug.Log("Points are 50");
                break;
            case 100:
                Debug.Log("Points are 100");
                break;
            default:
                Debug.Log("You need 50 or 100 pts to receive a message");
                break;
        }
        
       
           
    }
}
