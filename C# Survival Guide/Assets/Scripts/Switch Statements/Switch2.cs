using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch2 : MonoBehaviour
{
    
    
    public MeshRenderer meshRenderer;
    private int _nextColor;
    

    // Start is called before the first frame update
    void Start()
    {
         meshRenderer = gameObject.GetComponent<MeshRenderer>();
         
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            _nextColor = 0;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            _nextColor = 1;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            _nextColor = 2;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            _nextColor = 3; 
        }

      switch(_nextColor)
        {
            case 0:
                meshRenderer.material.color = Color.red;
                break;
            case 1:
                meshRenderer.material.color = Color.green;
                break;
            case 2:
                meshRenderer.material.color = Color.black;
                break;
            case 3:
                meshRenderer.material.color = Color.white;
                break;
            default:
                meshRenderer.material.color = Color.blue;
                break;
        }
    
    }






    //void GetInput(KeyCode input)
    //{
    //    switch (input)
    //    {
    //        case KeyCode.Alpha0:
    //            break;

    //        case KeyCode.Alpha1:
    //            meshRenderer.material.color = Color.black;
    //            break;

    //        default:
    //            break;
    //    }
    //}
}
