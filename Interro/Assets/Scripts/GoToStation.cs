using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;

    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Police Station Scene");
    }
}
