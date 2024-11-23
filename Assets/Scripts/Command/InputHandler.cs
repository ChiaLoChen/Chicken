using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Command spawnKey;
    private ChickenSpawn _chicken;
    
    // Start is called before the first frame update
    void Start()
    {
        _chicken = FindObjectOfType<ChickenSpawn>();
        spawnKey = new SpawnKey(_chicken);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            spawnKey.Execute();
        }
    }
}
