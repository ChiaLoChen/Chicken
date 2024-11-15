using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSummon : Spawn
{
    public override void Create(Vector3 position, GameObject prefab, GameObject[] locations)
    {
        GameObject createPrefab = GameObject.Instantiate(prefab, position, Quaternion.identity);
        createPrefab.GetComponent<Chicken>().locations = locations;
    }
}
