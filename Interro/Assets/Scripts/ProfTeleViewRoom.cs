using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfTeleViewRoom : MonoBehaviour
{
    public GameObject prof;
    public GameObject viewDoor;
    private Vector3 teleTo;
    // Start is called before the first frame update
    void Start()
    {
        teleTo = new Vector3(-1.037f, 0.01f, -12.1f);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Entered Room");
            prof.transform.position = teleTo;
            prof.transform.eulerAngles = new Vector3(0, -438, 0);
        }
    }
}
