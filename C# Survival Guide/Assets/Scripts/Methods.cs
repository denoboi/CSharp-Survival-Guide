using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    
    void Start()
    {
        Sum(5, 2);
    }


    private void Sum(int a, int b)
    {
        Debug.Log(a * b);
    }
}
