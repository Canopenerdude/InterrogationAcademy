using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObjects : MonoBehaviour
{
    public static GameObject Player;
    
    public static Vector3 RockStartPos;
    public static Vector3 LampStartPos;
    public static Vector3 CarStartPos;
    
    public static float PushDist = 10f;
    // Start is called before the first frame update
    void Start()
    {
        RockStartPos = GameObject.Find("Rock1").transform.position;
        LampStartPos = GameObject.Find("Lamp1").transform.position;
        CarStartPos = GameObject.Find("Car1").transform.position;
        Player = GameObject.Find("Player");
        Debug.Log(Player.transform.position);
        Debug.Log(LampStartPos);
        Debug.Log(CarStartPos);
        Debug.Log(RockStartPos);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(Player.transform.position, Player.transform.forward, out hit, PushDist))
            {
                if(hit.transform.gameObject.CompareTag("canPress"))
                {
                    Debug.Log("Hit!");
                    ResetObjs();
                }
            }
        }
    }

    void ResetObjs()
    {
        GameObject.Find("Rock1").transform.position = RockStartPos;
        GameObject.Find("Lamp1").transform.position = LampStartPos;
        GameObject.Find("Car1").transform.position = CarStartPos;
        Debug.Log("Reset Objects");
    }
}
