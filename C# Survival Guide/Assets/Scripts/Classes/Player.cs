using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats
{
    public string name;
    public float fireRate;
    public int ammoCount;

    public WeaponStats(string name, float fireRate, int ammoCount)
    {
        //Initialize things here
        this.name = name;
        this.fireRate = fireRate;
        this.ammoCount = ammoCount;
    }
}



public class Player : MonoBehaviour
{
    private WeaponStats blasters;
    private WeaponStats rockets;

    
    void Start()
    {
        blasters = new WeaponStats("vurucu", 0.5f, 30) ; //bu yeni bir obje yaratiyor. simdi fieldlar ile kullanabiliriz.
        rockets = new WeaponStats("Rockets",0.75f, 3);  
    }

}
