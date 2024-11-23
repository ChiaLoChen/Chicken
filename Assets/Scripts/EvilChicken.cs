using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilChicken : MonoBehaviour
{
    private GameObject closestTarget;
    private List<GameObject> targets = new List<GameObject>();
    public float speed;

    // Update is called once per frame
    void Update()
    {
        UpdateObjectsWithTag();
        if (targets.Count > 0)
        {
            FindClosestTarget();

            if (closestTarget != null)
            {
                
                transform.position = Vector3.MoveTowards(transform.position, closestTarget.transform.position,
                    speed * Time.deltaTime);
            }
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("chicken"))
        {
            targets.Remove(collider.gameObject);
            Destroy(collider.gameObject);
        }
    }

    void UpdateObjectsWithTag()
    {
        targets.Clear();
        GameObject[] objects = GameObject.FindGameObjectsWithTag("chicken");
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
}
