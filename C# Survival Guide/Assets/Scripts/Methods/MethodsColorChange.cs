using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodsColorChange : MonoBehaviour
{
    public GameObject cube;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(cube, Color.red);
        }
    }


    private void ChangeColor(GameObject obj, Color colorToChange)
    {
        obj.GetComponent<MeshRenderer>().material.color = colorToChange;
        
    }
}
