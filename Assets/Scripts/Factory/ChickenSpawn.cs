using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChickenSpawn : MonoBehaviour
{
    public GameObject chicken;
    public GameObject[] locations;
    public TextMeshProUGUI numberOfChicken;
    private int chickenCount = 0;
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Spawn chicks = new ChickenSummon();
            chicks.Create(this.transform.position, chicken, locations);
            chickenCount++;
        }
        numberOfChicken.text = "Chickens: " + chickenCount.ToString();
    }

    public int GetNumberOfChickens()
    {
        return chickenCount;
    }
}
