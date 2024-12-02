using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfIntro : MonoBehaviour
{
    public AudioSource profSound;
    public AudioClip introP;
    public GameObject profText;
    // Update is called once per frame
    private IEnumerator OnMouseUpAsButton()
    {
        profSound.clip = introP;
        profSound.Play();
        yield return new WaitForSeconds(profSound.clip.length);
        profText.SetActive(false);
    }
}
