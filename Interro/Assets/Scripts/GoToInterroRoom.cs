using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToInterroRoom : MonoBehaviour
{
    public GameObject holdPosition;
    public GameObject saulDoc;
    public GameObject danDoc;
    public GameObject brianDoc;

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (saulDoc.transform.IsChildOf(holdPosition.transform))
            {
                SceneManager.LoadScene("SaulInterroRoom");
            }

            if (danDoc.transform.IsChildOf(holdPosition.transform))
            {
                SceneManager.LoadScene("DanInterroRoom");
            }

            if (brianDoc.transform.IsChildOf(holdPosition.transform))
            {
                SceneManager.LoadScene("BrianInterroRoom");
            }
        }
    }
}
