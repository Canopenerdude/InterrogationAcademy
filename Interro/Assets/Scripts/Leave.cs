using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveGuilty : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.name)
        {
            case "DoorGuilty":
                SceneManager.LoadScene("Correct", LoadSceneMode.Single);
                break;
            case "DoorInnocent":
                SceneManager.LoadScene("Incorrect", LoadSceneMode.Single);
                break;
        }
    }
}
