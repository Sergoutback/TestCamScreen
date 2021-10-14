using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleAnimation : MonoBehaviour
{
    void Start()
    {
        GetComponent<Animation>().Play("AppleAnimation");
    }

    void Update()
    {
        GetComponent<Animation>().Play("AppleAnimation");
    }
}