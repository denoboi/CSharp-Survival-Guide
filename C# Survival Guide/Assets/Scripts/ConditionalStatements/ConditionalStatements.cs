using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalStatements : MonoBehaviour
{
    public int quiz1;
    public int quiz2;
    public int quiz3; 
    public int quiz4; 
    public int quiz5; 

    private float average;

    // Start is called before the first frame update
    void Start()
    {
        quiz1 = Random.Range(0, 100);
        quiz2 = Random.Range(0, 100);
        quiz3 = Random.Range(0, 100);
        quiz4 = Random.Range(0, 100);
        quiz5 = Random.Range(0, 100);

        average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;

        if(average > 90)
        {
            Debug.Log("Your grade is A: " + average);
        }
        else if(average >= 80 && average <= 90)
        {
            Debug.Log("Your grade is B: " + average);
        }
        else if(average >= 70 && average < 80)
        {
            Debug.Log("Your grade is C: " + average);
        }
        else
        {
            Debug.Log("You are idiot: " + average);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
