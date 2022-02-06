using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalStatements2 : MonoBehaviour
{
    private int _score;
    public GameObject cube;
    private MeshRenderer rend;
    

    // Starts called before the first frame update
    void Start()
    {
        rend = cube.GetComponent<MeshRenderer>();
        rend.material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _score += 10;
            if (_score > 50)
            {
               rend.material.color = Color.cyan;
            }
        }
        
    }
}
