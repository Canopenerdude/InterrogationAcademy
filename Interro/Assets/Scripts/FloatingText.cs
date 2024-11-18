using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Transform mainCamera;
    Transform button;
    Transform worldSpaceCanvas;

    public Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main.transform;
        button = transform.parent;
        worldSpaceCanvas = GameObject.Find("ResetText").transform;
        
        transform.SetParent(worldSpaceCanvas);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - mainCamera.transform.position);
        transform.position = button.position + offset;
    }
}
