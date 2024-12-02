using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiltyCollider : MonoBehaviour
{
    public AudioSource guiltySound;
    public AudioClip guiltyB;
    public AudioClip guiltyD;
    public AudioClip guiltyS;

    IEnumerator OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "DanDoc")
        {
            guiltySound.clip = guiltyD;
            guiltySound.Play();
            yield return new WaitForSeconds(guiltySound.clip.length);
            Application.Quit();
        }

        if (collision.gameObject.name == "SaulDoc")
        {
            guiltySound.clip = guiltyS;
            guiltySound.Play();
            yield return new WaitForSeconds(guiltySound.clip.length);
            Application.Quit();
        }

        if (collision.gameObject.name == "BrianDoc")
        {
            guiltySound.clip = guiltyB;
            guiltySound.Play();
            yield return new WaitForSeconds(guiltySound.clip.length);
            Application.Quit();
        }
    }
}
