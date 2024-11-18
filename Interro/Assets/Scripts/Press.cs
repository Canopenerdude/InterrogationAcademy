using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Press : MonoBehaviour
{
    private GameObject q1;
    private GameObject q2;
    private GameObject q3;
    
    private Vector3 q1Pos;
    private Vector3 q2Pos;
    private Vector3 q3Pos;

    void Start()
    {
        q1 = GameObject.Find("q1");
        q2 = GameObject.Find("q2");
        q3 = GameObject.Find("q3");
        q1Pos = q1.transform.position;
        q2Pos = q2.transform.position;
        q3Pos = q3.transform.position;
    }
    private void OnMouseUpAsButton()
    {
        Debug.Log("Press as button");
        q1.SetActive(true);
        q1.transform.position = q1Pos;
        q2.SetActive(true);
        q2.transform.position = q2Pos;
        q3.SetActive(true);
        q3.transform.position = q3Pos;
    }
}
