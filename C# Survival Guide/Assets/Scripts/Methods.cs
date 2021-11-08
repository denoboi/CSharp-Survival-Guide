using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    public int health;

    public void BossDamage(int bossDamage)
    {
        health -= bossDamage;
    }

    public void Healer(int heal)
    {
        health += heal;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            BossDamage(20);
        }

        if(Input.GetKeyDown(KeyCode.H))
        {
            Healer(10);
        }
    }
}
