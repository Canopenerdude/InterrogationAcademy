using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Interrogate : MonoBehaviour
{
    private AudioSource q1Line; //Audio line for q1
    public AudioSource q2Line; //Audio line for q2
    public AudioSource q3Line; //Audio line for q3
    public AudioSource angyLine; //Audio line when patience >= 6

    private int patience; //Interviewee's patience; if >= '6', a different line will play
    
    public bool q1Collided; //did the q1 collide?
    public bool q2Collided; //did the q2 collide?
    public bool q3Collided; //did the q3 collide?
    public GameObject q1; //the q1 that did the colliding
    public GameObject q2; //the q2 that did the colliding
    public GameObject q3; //the q3 that did the colliding
    
    // Start is called before the first frame update
    void Start()
    {
        //Grabbing the audio lines for the objects
        q1Line = GetComponent<AudioSource>();
        q2Line = GameObject.Find("q2Line").GetComponent<AudioSource>();
        q3Line = GameObject.Find("q3Line").GetComponent<AudioSource>();
        angyLine = GameObject.Find("Angy").GetComponent<AudioSource>();
        q1 = GameObject.Find("q1");
        q2 = GameObject.Find("q2");
        q3 = GameObject.Find("q3");
    }

    // Update is called once per frame
    void Update()
    {
        //These ifs make sure the audio lines only trigger once, and increment the patience
        if (q1Collided)
        {
            q1Collided = false;
            patience++;
        }

        if (q2Collided)
        {
            q2Collided = false;
            patience++;
        }

        if (q3Collided)
        {
            q3Collided = false;
            patience++;
        }
    }

    IEnumerator OnCollisionEnter(Collision collision)
    {
        //If an object with the name 'x' enters the collision, play the corresponding line, wait three seconds, and then despawn the object
        if (collision.gameObject.name == "q1")
        {
            if (patience >= 6)
            {
                Debug.Log("Angy Line!");
                angyLine.Play(0);
                yield return new WaitForSeconds(angyLine.clip.length);
                q1Collided = true;
                q1.SetActive(false);
            }
            else
            {
                Debug.Log("This is a first line!");
                q1Line.Play(0);
                yield return new WaitForSeconds(q1Line.clip.length);
                q1Collided = true;
                q1.SetActive(false);
            }
        }

        else if (collision.gameObject.name == "q2")
        {
            if (patience >= 6)
            {
                Debug.Log("Angy Line!");
                angyLine.Play(0);
                yield return new WaitForSeconds(angyLine.clip.length);
                q2Collided = true;
                q2.SetActive(false);
            }
            else
            {
                Debug.Log("This is a second line!");
                q2Line.Play(0);
                yield return new WaitForSeconds(q2Line.clip.length);
                q2Collided = true;
                q2.SetActive(false);
            }
        }

        else if (collision.gameObject.name == "q3")
        {
            if (patience >= 6)
            {
                Debug.Log("Angy Line!");
                angyLine.Play(0);
                yield return new WaitForSeconds(angyLine.clip.length);
                q3Collided = true;
                q3.SetActive(false);
            }
            else
            {
                Debug.Log("This is a third line!");
                q3Line.Play(0);
                yield return new WaitForSeconds(q3Line.clip.length);
                q3Collided = true;
                q3.SetActive(false);
            }
        }
    }
}
