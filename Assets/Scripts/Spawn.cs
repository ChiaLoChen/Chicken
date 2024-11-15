using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject chicken;

    public GameObject[] locations;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            GameObject chicks = Instantiate(chicken, this.transform.position, Quaternion.identity);
            chicks.GetComponent<Chicken>().locations = locations;
        }
    }
}
