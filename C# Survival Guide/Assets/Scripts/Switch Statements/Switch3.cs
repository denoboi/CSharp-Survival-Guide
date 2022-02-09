using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch3 : MonoBehaviour
{
    public int WeaponID;
    public GameObject gun, knife, assaultRifle, SMG, rifle, grenadeThrower;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (WeaponID)
        {
            case 1:
                Debug.Log("You selected Gun");
                break;
            case 2:
                Debug.Log("You selected Knife");
                break;
            case 3:
                Debug.Log("You selected Assault Rifle");
                break;
            case 4:
                Debug.Log("You selected SMG");
                break;
            case 5:
                Debug.Log("You selected Rifle");
                break;
            case 6:
                Debug.Log("You selected Grenade Thrower");
                break;

        }
    }
}
