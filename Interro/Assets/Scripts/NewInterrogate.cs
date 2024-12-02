using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewInterrogate : MonoBehaviour
{
    private AudioSource audioSource;
    
    public AudioClip q1B;
    public AudioClip q2B;
    public AudioClip q3B;
    public AudioClip q4B;
    public AudioClip q5B;
    public AudioClip q6B;

    public AudioClip q1S;
    public AudioClip q2S;
    public AudioClip q3S;
    public AudioClip q4S;
    public AudioClip q5S;
    public AudioClip q6S;

    public AudioClip q1D;
    public AudioClip q2D;
    public AudioClip q3D;
    public AudioClip q4D;
    public AudioClip q5D;
    public AudioClip q6D;

    public AudioClip angyB;
    public AudioClip angyS;
    public AudioClip angyD;

    public AudioClip introB;
    public AudioClip introS;
    public AudioClip introD;
    
    private int patience; //Interviewee's patience; if >= '6', a different line will play
    private int suspect;
    
    public bool q1Collided; //did the q1 collide?
    public bool q2Collided; //did the q2 collide?
    public bool q3Collided; //did the q3 collide?
    public bool q4Collided;
    public bool q5Collided;
    public bool q6Collided;
    public GameObject q1; //the q1 that did the colliding
    public GameObject q2; //the q2 that did the colliding
    public GameObject q3; //the q3 that did the colliding
    public GameObject q4;
    public GameObject q5;
    public GameObject q6;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (GameObject.Find("Dan") != null)
        {
            suspect = 1;
            audioSource.clip = introD;
            audioSource.Play();
        }

        if (GameObject.Find("Saul") != null)
        {
            suspect = 2;
            audioSource.clip = introS;
            audioSource.Play();
        }

        if (GameObject.Find("Brian") != null)
        {
            suspect = 3;
            audioSource.clip = introB;
            audioSource.Play();
        }
            
    }

    // Update is called once per frame
    void Update()
    {
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

        if (q4Collided)
        {
            q4Collided = false;
            patience++;
        }

        if (q5Collided)
        {
            q5Collided = false;
            patience++;
        }

        if (q6Collided)
        {
            q6Collided = false;
            patience++;
        }
    }

    private IEnumerator OnCollisionEnter(Collision collision)
    {
        if (suspect == 1)
        {
            if (patience > 6)
            {
                audioSource.clip = angyD;
                audioSource.Play();
            }
            else if (collision.gameObject.name == "q1")
            {
                audioSource.clip = q1D;
                audioSource.Play();
                yield return new WaitForSeconds(q1D.length);
                q1Collided = true;
                q1.SetActive(false);
             
            }
            else if (collision.gameObject.name == "q2")
            {
                audioSource.clip = q2D;
                audioSource.Play();
                yield return new WaitForSeconds(q2D.length);
                q2Collided = true;
                q2.SetActive(false);
            }
            else if (collision.gameObject.name == "q3")
            {
                audioSource.clip = q3D;
                audioSource.Play();
                yield return new WaitForSeconds(q3D.length);
                q3Collided = true;
                q3.SetActive(false);
            }
            else if (collision.gameObject.name == "q4")
            {
                audioSource.clip = q4D;
                audioSource.Play();
                yield return new WaitForSeconds(q4D.length);
                q4Collided = true;
                q4.SetActive(false);
            }
            else if (collision.gameObject.name == "q5")
            {
                audioSource.clip = q5D;
                audioSource.Play();
                yield return new WaitForSeconds(q5D.length);
                q5Collided = true;
                q5.SetActive(false);
            }
            else if (collision.gameObject.name == "q6")
            {
                audioSource.clip = q6D;
                audioSource.Play();
                yield return new WaitForSeconds(q6D.length);
                q6Collided = true;
                q6.SetActive(false);
            }
        }
        else if (suspect == 2)
        {
            if (patience > 6)
            {
                audioSource.clip = angyS;
                audioSource.Play();
            }
            else if (collision.gameObject.name == "q1")
            {
                audioSource.clip = q1S;
                audioSource.Play();
                yield return new WaitForSeconds(q1S.length);
                q1Collided = true;
                q1.SetActive(false);
            }
            else if (collision.gameObject.name == "q2")
            {
                audioSource.clip = q2S;
                audioSource.Play();
                yield return new WaitForSeconds(q2S.length);
                q2Collided = true;
                q2.SetActive(false);
            }
            else if (collision.gameObject.name == "q3")
            {
                audioSource.clip = q3S;
                audioSource.Play();
                yield return new WaitForSeconds(q3S.length);
                q3Collided = true;
                q3.SetActive(false);
            }
            else if (collision.gameObject.name == "q4")
            {
                audioSource.clip = q4S;
                audioSource.Play();
                yield return new WaitForSeconds(q4S.length);
                q4Collided = true;
                q4.SetActive(false);
            }
            else if (collision.gameObject.name == "q5")
            {
                audioSource.clip = q5S;
                audioSource.Play();
                yield return new WaitForSeconds(q5S.length);
                q5Collided = true;
                q5.SetActive(false);
            }
            else if (collision.gameObject.name == "q6")
            {
                audioSource.clip = q6S;
                audioSource.Play();
                yield return new WaitForSeconds(q6S.length);
                q6Collided = true;
                q6.SetActive(false);
            }
        }
        else if (suspect == 3)
        {
            if (patience > 6)
            {
                audioSource.clip = angyB;
                audioSource.Play();
            }
            else if (collision.gameObject.name == "q1")
            {
                audioSource.clip = q1B;
                audioSource.Play();
                yield return new WaitForSeconds(q1B.length);
                q1Collided = true;
                q1.SetActive(false);
            }
            else if (collision.gameObject.name == "q2")
            {
                audioSource.clip = q2B;
                audioSource.Play();
                yield return new WaitForSeconds(q2B.length);
                q2Collided = true;
                q2.SetActive(false);
            }
            else if (collision.gameObject.name == "q3")
            {
                audioSource.clip = q3B;
                audioSource.Play();
                yield return new WaitForSeconds(q3B.length);
                q3Collided = true;
                q3.SetActive(false);
            }
            else if (collision.gameObject.name == "q4")
            {
                audioSource.clip = q4B;
                audioSource.Play();
                yield return new WaitForSeconds(q4B.length);
                q4Collided = true;
                q4.SetActive(false);
            }
            else if (collision.gameObject.name == "q5")
            {
                audioSource.clip = q5B;
                audioSource.Play();
                yield return new WaitForSeconds(q5B.length);
                q5Collided = true;
                q5.SetActive(false);
            }
            else if (collision.gameObject.name == "q6")
            {
                audioSource.clip = q6B;
                audioSource.Play();
                yield return new WaitForSeconds(q6B.length);
                q6Collided = true;
                q6.SetActive(false);
            }
        }
    }
}
