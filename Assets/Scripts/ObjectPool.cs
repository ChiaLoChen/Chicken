using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    // The prefab for the bullet
    public GameObject bulletPrefab;

    // Pool of bullets (list of inactive objects)
    private Queue<GameObject> bulletPool = new Queue<GameObject>();

    // Number of bullets to create at the start
    public int poolSize = 10;

    void Start()
    {
        // Initialize the pool with bullets
        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.SetActive(false); // Set it inactive initially
            bulletPool.Enqueue(bullet); // Add to the pool
        }
    }

    // Get a bullet from the pool
    public GameObject GetBullet()
    {
        if (bulletPool.Count > 0)
        {
            GameObject bullet = bulletPool.Dequeue(); // Get a bullet from the pool
            bullet.SetActive(true); // Activate it
            return bullet;
        }
        else
        {
            // Optionally, instantiate new bullets if the pool is empty
            GameObject bullet = Instantiate(bulletPrefab);
            return bullet;
        }
    }

    // Return a bullet to the pool
    public void ReturnBullet(GameObject bullet)
    {
        bullet.SetActive(false); // Deactivate it
        bulletPool.Enqueue(bullet); // Return to the pool
    }
}