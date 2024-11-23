using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChickenSpawn : Singleton<ChickenSpawn>
{
    public GameObject chicken;
    public GameObject evilChicken;
    public GameObject[] locations;

    void Start()
    {
        locations = GameObject.FindGameObjectsWithTag("locations");
    }

    public void SpawnChicken()
    {
        Spawn chicks = new ChickenSummon();
        if (Random.value > 0.9)
        {
            chicks.Create(this.transform.position, evilChicken, locations);
        }
        else
        {
            chicks.Create(this.transform.position, chicken, locations);
        }
    }
}
