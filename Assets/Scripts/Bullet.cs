using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 100f;
    public GameObject target;
    private float timer = 0f;
    private float deathTime = 5f;

    public void SetTarget(GameObject newTarget)
    {
        target = newTarget;
    }

    void Start()
    {
        if (target != null)
        {
            // Make sure the bullet starts moving immediately
            Vector3 direction = (target.transform.position - transform.position).normalized;
            Rigidbody rb = GetComponent<Rigidbody>();

            // If the bullet has a Rigidbody, set its velocity towards the target
            if (rb != null)
            {
                rb.velocity = direction * speed;
            }
            else
            {
                // If there is no Rigidbody, move using transform
                transform.position =
                    Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
            }
        }
    }

    void Update()
    {
        if (target != null)
        {
            transform.position =
                Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }
        timer += Time.deltaTime;
        if (timer > deathTime)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("evilChicken"))
        {
            Destroy(collider.gameObject);
        }
    }

    /*public void OnCollisionWithObject()
    {
        gameObject.SetActive(false);
    }*/
}
