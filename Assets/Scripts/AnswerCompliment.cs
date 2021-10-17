using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnswerCompliment : MonoBehaviour
{
    public Text TextAnswerScreen;
    public string text;
    public ArrayOfCompliments arrOfCompl;


    public void Start()
    {
        arrOfCompl = GetComponent<ArrayOfCompliments>();
        arrOfCompl.TextArr();
        TextAnswerScreen.text = arrOfCompl.TextArrOfCompl.text;
    }
}



