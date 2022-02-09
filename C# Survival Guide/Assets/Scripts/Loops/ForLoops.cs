using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }

        for (int i = 10; i <= 20; i+=2)
        {
            Debug.Log(i);
        }

        for (int i = 20; i <= 30; i++)
        {
            if(i % 2 == 1)
            {
                Debug.Log(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
