using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    public GameObject[] locations;
    public float speed;
    private int currentLocation = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, locations[currentLocation].transform.position,
            speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("locations"))
        {
            if (currentLocation < locations.Length)
            {
                currentLocation++;
                Debug.Log(currentLocation);
            }
            else
            {
                Debug.Log("chicken arrived");
                Destroy(this.gameObject);
            }
        }
    }
}
