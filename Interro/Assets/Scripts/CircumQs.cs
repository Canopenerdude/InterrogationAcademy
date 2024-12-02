using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircumQs : MonoBehaviour
{
    private GameObject q1;
    private GameObject q2;
    private GameObject q3;
    private GameObject q4;
    private GameObject q5;
    private GameObject q6;

    private Vector3 q4Pos;
    private Vector3 q5Pos;
    private Vector3 q6Pos;

    private Vector3 q4Rot;
    private Vector3 q5Rot;
    private Vector3 q6Rot;
    // Start is called before the first frame update
    void Start()
    {
        q1 = GameObject.Find("q1");
        q2 = GameObject.Find("q2");
        q3 = GameObject.Find("q3");
        q4 = GameObject.Find("q4");
        q5 = GameObject.Find("q5");
        q6 = GameObject.Find("q6");
        q4Pos = q4.transform.position;
        q5Pos = q5.transform.position;
        q6Pos = q6.transform.position;
        q4Rot = q4.transform.eulerAngles;
        q5Rot = q5.transform.eulerAngles;
        q6Rot = q6.transform.eulerAngles;
        q4.SetActive(false);
        q5.SetActive(false);
        q6.SetActive(false);
    }

    private void OnMouseUpAsButton()
    {
        q1.SetActive(false);
        q2.SetActive(false);
        q3.SetActive(false);
        q4.SetActive(true);
        q5.SetActive(true);
        q6.SetActive(true);
        q4.transform.position = q4Pos;
        q5.transform.position = q5Pos;
        q6.transform.position = q6Pos;
        q4.transform.eulerAngles = q4Rot;
        q5.transform.eulerAngles = q5Rot;
        q6.transform.eulerAngles = q6Rot;
    }
}
