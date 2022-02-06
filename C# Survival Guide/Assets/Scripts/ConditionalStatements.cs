using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalStatements : MonoBehaviour
{
    public int quiz1 = 90;
    public int quiz2 = 90;
    public int quiz3 = 44;
    public int quiz4 = 69;
    public int quiz5 = 88;

    private float average;
    // Start is called before the first frame update
    void Start()
    {
        average = quiz1 + quiz2 + quiz3 + quiz4 + quiz5 / 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
