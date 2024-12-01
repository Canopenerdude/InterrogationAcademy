using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dispQuestions : MonoBehaviour
{
    public GameObject qNumber;
    public GameObject qText;
    // Start is called before the first frame update
    void Start()
    {
        qText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent != null)
        {
            qText.SetActive(true);
        }
        else
        {
            qText.SetActive(false);
        }
    }
}
