using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChickenSpawn : MonoBehaviour
{
    public GameObject chicken;
    public GameObject evilChicken;
    public GameObject[] locations;
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Spawn chicks = new ChickenSummon();
            if (Random.value > 0.5)
            {
                chicks.Create(this.transform.position, evilChicken, locations);
            }
            else
            {
                chicks.Create(this.transform.position, chicken, locations);
            }
        }
    }
}
