using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionStatements : MonoBehaviour
{
    public int points;
    private bool hasSaidMessage;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            points += 10;
        }

        if(points >= 50 && hasSaidMessage == false)
        {
            Debug.Log("You are awesome!");
            hasSaidMessage = true;
        }
    }
}
