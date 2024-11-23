using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    public GameObject[] locations;
    public float speed;

    private int currentLocation = 0;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentLocation < locations.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, locations[currentLocation].transform.position,
                speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("locations"))
        {
            if (currentLocation < locations.Length)
            {
                currentLocation++;
            }
        }

        if (collider.gameObject.name == "chicken house")
        {
            Debug.Log("chicken arrived");
            collider.GetComponent<Money>().AddChicken();
            Destroy(this.gameObject);
        }
    }
}
