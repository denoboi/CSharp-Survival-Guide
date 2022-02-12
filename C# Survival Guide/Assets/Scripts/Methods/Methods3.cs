using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods3 : MonoBehaviour
{
    //return type methods


    public int total;
    public int total2;

    private void Start()
    {
        total = Sum(5,2);
        total2 = Sum(9,2);
    }


    private int Sum(int a, int b)
    {

        return a + b;
    }
}
