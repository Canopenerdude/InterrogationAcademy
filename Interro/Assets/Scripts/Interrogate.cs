using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrogate : MonoBehaviour
{
    public AudioSource rockLine;
    public AudioSource lampLine;
    public AudioSource carLine;
    // Start is called before the first frame update
    void Start()
    {
        rockLine = GetComponent<AudioSource>();
        lampLine = GameObject.Find("LampLine").GetComponent<AudioSource>();
        carLine = GameObject.Find("CarLine").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rockCollided == true)
        {
            rockCollided = false;
        }

        if (lampCollided == true)
        {
            lampCollided = false;
        }

        if (carCollided == true)
        {
            carCollided = false;
        }
    }

    public  bool rockCollided;
    public  bool lampCollided;
    public  bool carCollided;
    public GameObject Rock;
    public GameObject Lamp;
    public GameObject Car;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Rock1")
        {
            Debug.Log("This is a first line!");
            rockLine.Play(0);
            rockCollided = true;
            Object.Destroy(Rock);
        }

        else if (collision.gameObject.name == "Lamp1")
        {
            Debug.Log("This is a second line!");
            lampLine.Play(0);
            lampCollided = true;
            Object.Destroy(Lamp);
        }

        else if (collision.gameObject.name == "Car1")
        {
            Debug.Log("This is a third line!");
            carLine.Play(0);
            carCollided = true;
            Object.Destroy(Car);
        }
    }
}
