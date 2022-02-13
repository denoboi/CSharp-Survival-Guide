using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods1 : MonoBehaviour
{
    private GameObject cube;
    

    // Update is called once per frame
    void Update()
    {
        ChangeColor();
    }

    void ChangeColor()
    {


        if(Input.GetKeyDown(KeyCode.Space))
        {
            cube = Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube));
            cube.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
