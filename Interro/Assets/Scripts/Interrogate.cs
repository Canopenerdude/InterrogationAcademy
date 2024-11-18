using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrogate : MonoBehaviour
{
    public AudioSource rockLine; //Audio line for rock1
    public AudioSource lampLine; //Audio line for lamp1
    public AudioSource carLine; //Audio line for car1
    public AudioSource angyLine; //Audio line when patience >= 10

    private int patience; //Interviewee's patience; if >= '10', a different line will play
    
    public bool rockCollided; //did the rock collide?
    public bool lampCollided; //did the lamp collide?
    public bool carCollided; //did the car collide?
    public GameObject Rock; //the rock that did the colliding
    public GameObject Lamp; //the lamp that did the colliding
    public GameObject Car; //the car that did the colliding
    
    // Start is called before the first frame update
    void Start()
    {
        //Grabbing the audio lines for the objects
        rockLine = GetComponent<AudioSource>();
        lampLine = GameObject.Find("LampLine").GetComponent<AudioSource>();
        carLine = GameObject.Find("CarLine").GetComponent<AudioSource>();
        angyLine = GameObject.Find("Angy").GetComponent<AudioSource>();
        Rock = GameObject.Find("Rock1");
        Lamp = GameObject.Find("Lamp1");
        Car = GameObject.Find("Car1");
    }

    // Update is called once per frame
    void Update()
    {
        //These ifs make sure the audio lines only trigger once, and increment the patience
        if (rockCollided)
        {
            rockCollided = false;
            patience++;
        }

        if (lampCollided)
        {
            lampCollided = false;
            patience++;
        }

        if (carCollided)
        {
            carCollided = false;
            patience++;
        }
    }

    IEnumerator OnCollisionEnter(Collision collision)
    {
        //If an object with the name 'x' enters the collision, play the corresponding line, wait three seconds, and then despawn the object
        if (collision.gameObject.name == "Rock1")
        {
            if (patience >= 10)
            {
                Debug.Log("Angy Line!");
                angyLine.Play(0);
                yield return new WaitForSeconds(3);
                rockCollided = true;
                Rock.SetActive(false);
            }
            else
            {
                Debug.Log("This is a first line!");
                rockLine.Play(0);
                yield return new WaitForSeconds(3);
                rockCollided = true;
                Rock.SetActive(false);
            }
        }

        else if (collision.gameObject.name == "Lamp1")
        {
            if (patience >= 10)
            {
                Debug.Log("Angy Line!");
                angyLine.Play(0);
                yield return new WaitForSeconds(3);
                lampCollided = true;
                Lamp.SetActive(false);
            }
            else
            {
                Debug.Log("This is a second line!");
                lampLine.Play(0);
                yield return new WaitForSeconds(3);
                lampCollided = true;
                Lamp.SetActive(false);
            }
        }

        else if (collision.gameObject.name == "Car1")
        {
            if (patience >= 10)
            {
                Debug.Log("Angy Line!");
                angyLine.Play(0);
                yield return new WaitForSeconds(3);
                carCollided = true;
                Car.SetActive(false);
            }
            else
            {
                Debug.Log("This is a third line!");
                carLine.Play(0);
                yield return new WaitForSeconds(3);
                carCollided = true;
                Car.SetActive(false);
            }
        }
    }
}
