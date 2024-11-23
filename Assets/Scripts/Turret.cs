using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private GameObject closestTarget;
    private List<GameObject> targets = new List<GameObject>();
    
    public Transform shootPoint;
    public GameObject bulletPrefab;
    public float rotationSpeed = 5f;
    public float shootingInterval = 1f;
    private float shootTimer = 0f;
    //public ObjectPool objectPool;
    public float bulletSpeed = 10f;
    // Update is called once per frame
    void Update()
    {
        UpdateObjectsWithTag();
        if (targets.Count > 0)
        {
            FindClosestTarget();

            if (closestTarget != null)
            {
                RotateTowardsTarget();
                shootTimer += Time.deltaTime;
                if (shootTimer >= shootingInterval)
                {
                    GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
                    bullet.GetComponent<Bullet>().SetTarget(closestTarget);
                    //GameObject bullet = objectPool.GetBullet();

                    //bullet.transform.position = shootPoint.position;
                    //Bullet bulletScript = bullet.GetComponent<Bullet>();
                    //bulletScript.speed = bulletSpeed;
                    shootTimer = 0f;
                }
            }
        }
    }

    void UpdateObjectsWithTag()
    {
        targets.Clear();
        GameObject[] objects = GameObject.FindGameObjectsWithTag("evilChicken");
        targets.AddRange(objects);
    }

    void FindClosestTarget()
    {
        float closestDistance = Mathf.Infinity;
        closestTarget = null;
        foreach (GameObject target in targets)
        {
            float distance = Vector3.Distance(transform.position, target.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestTarget = target;
            }
        }
    }

    void RotateTowardsTarget()
    {
        Vector3 direction = closestTarget.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);
    }
}
