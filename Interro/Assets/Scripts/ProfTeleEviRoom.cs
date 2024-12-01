using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfTeleEviRoom : MonoBehaviour
{
    public GameObject prof;
    private Vector3 teleTo;
    // Start is called before the first frame update
    void Start()
    {
        teleTo = new Vector3(-15.2f, 0.05f, 3.6f);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Entered Evidence Area");
            prof.transform.position = teleTo;
            prof.transform.eulerAngles = new Vector3(0, -81, 0);
        }
    }
}
