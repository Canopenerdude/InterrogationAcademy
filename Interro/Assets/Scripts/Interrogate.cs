using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrogate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool rockCollided;
    public bool lampCollided;
    public bool carCollided;

    void OnCollisionEnter(Collision collision)
    {
        while (collision.gameObject.name == "Rock1")
        {
            Debug.Log("This is a first line!");
            rockCollided = true;
        }

        while (collision.gameObject.name == "Lamp1")
        {
            Debug.Log("This is a second line!");
            lampCollided = true;
        }

        while (collision.gameObject.name == "Car1")
        {
            Debug.Log("This is a third line!");
            carCollided = true;
        }
    }
}
