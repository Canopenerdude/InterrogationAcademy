using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FallCatch : MonoBehaviour
{
    private Vector3 playerStartPos;
    public GameObject player;
    void Start()
    {
        playerStartPos = GameObject.FindGameObjectWithTag("Player").transform.position;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player.transform.position = playerStartPos;
        }
    }
}
