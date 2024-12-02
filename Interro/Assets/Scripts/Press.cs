using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Press : MonoBehaviour
{
    private GameObject q1;
    private GameObject q2;
    private GameObject q3;
    private GameObject q4;
    private GameObject q5;
    private GameObject q6;
    
    private Vector3 q1Pos;
    private Vector3 q2Pos;
    private Vector3 q3Pos;
    private Vector3 q4Pos;
    private Vector3 q5Pos;
    private Vector3 q6Pos;
    
    private Quaternion q1Rot;
    private Quaternion q2Rot;
    private Quaternion q3Rot;
    private Quaternion q4Rot;
    private Quaternion q5Rot;
    private Quaternion q6Rot;

    void Start()
    {
        q1 = GameObject.Find("q1");
        q2 = GameObject.Find("q2");
        q3 = GameObject.Find("q3");
        q1Pos = q1.transform.position;
        q2Pos = q2.transform.position;
        q3Pos = q3.transform.position;
        q1Rot = q1.transform.rotation;
        q2Rot = q2.transform.rotation;
        q3Rot = q3.transform.rotation;
    }
    private void OnMouseUpAsButton()
    {
        //Debug.Log("Press as button");
        q4 = GameObject.Find("q4");
        q5 = GameObject.Find("q5");
        q6 = GameObject.Find("q6");
        q4.SetActive(false);
        q5.SetActive(false);
        q6.SetActive(false);
        q1.SetActive(true);
        q1.transform.position = q1Pos;
        q1.transform.rotation = q1Rot;
        q2.SetActive(true);
        q2.transform.position = q2Pos;
        q2.transform.rotation = q2Rot;
        q3.SetActive(true);
        q3.transform.position = q3Pos;
        q3.transform.rotation = q3Rot;
    }
}
