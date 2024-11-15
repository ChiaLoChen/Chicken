using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawn
{
    public abstract void Create(Vector3 postion, GameObject gameobject, GameObject[] locations);
}