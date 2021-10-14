using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleAnimation : MonoBehaviour
{
    public void Update()
    {
        GetComponent<Animation>().Play("AppleAnimation");
    }
}