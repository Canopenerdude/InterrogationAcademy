using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Press : MonoBehaviour
{
    private GameObject rock;
    private GameObject lamp;
    private GameObject car;
    
    private Vector3 rockPos;
    private Vector3 lampPos;
    private Vector3 carPos;

    void Start()
    {
        rock = GameObject.Find("Rock1");
        lamp = GameObject.Find("Lamp1");
        car = GameObject.Find("Car1");
        rockPos = rock.transform.position;
        lampPos = lamp.transform.position;
        carPos = car.transform.position;
    }
    private void OnMouseUpAsButton()
    {
        Debug.Log("Press as button");
        rock.SetActive(true);
        rock.transform.position = rockPos;
        lamp.SetActive(true);
        lamp.transform.position = lampPos;
        car.SetActive(true);
        car.transform.position = carPos;
    }
}
