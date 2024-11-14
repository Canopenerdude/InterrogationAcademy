using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{
    public GameObject player;
    public float pressRange = 10f;
    private Vector3 rockOgPos;
    private Vector3 lampOgPos;
    private Vector3 carOgPos;
    
    // Start is called before the first frame update
    void Start()
    {
        rockOgPos = GameObject.Find("Rock1").transform.position;
        lampOgPos = GameObject.Find("Lamp1").transform.position;
        carOgPos = GameObject.Find("Car1").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E Pressed");
            RaycastHit hit;
            if (Physics.Raycast(player.transform.position, transform.TransformDirection(Vector3.forward), out hit, pressRange))
            {
                if (hit.transform.gameObject.CompareTag("canPress"))
                {
                    ResetObjects();
                }
            }
        }
    }

    void ResetObjects()
    {
        GameObject.Find("Rock1").transform.position = rockOgPos;
        GameObject.Find("Lamp1").transform.position = lampOgPos;
        GameObject.Find("Car1").transform.position = carOgPos;
        Debug.Log("Reset Objects");
    }
}
