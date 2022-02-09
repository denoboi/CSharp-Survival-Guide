using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays1 : MonoBehaviour
{

    public string[] names = new string[] { "Ahmet", "Ali", "Ayse", "Denoboi", "Ezgi" };
    public int[] ages = new int[] { 5, 10, 54, 30, 29 };
    public string[] cars = new string[] { "Ford", "BMW", "Ferrari", "Koenigsegg", "Tofas" };
    

    // Start is called before the first frame update
    void Start()
    {
       
           

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(" Name: " + names[4] + " Age: " + ages[4] + " Fav Car: " + cars[4]);
        }
    }
}
