using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods4 : MonoBehaviour
{
    public GameObject[] players;

    void Start()
    {
        players = GetAllPlayers();
    }

   
    void Update()
    {
        
    }

    private GameObject[] GetAllPlayers()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");

        foreach(var p in allPlayers)
        {
            p.GetComponent<Transform>().position = new Vector3(Random.Range(0, 100), Random.Range(0,100), Random.Range(0,100));
           
        }

        return allPlayers;
    }

}
