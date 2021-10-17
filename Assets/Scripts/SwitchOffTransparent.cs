using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchOffTransparent : MonoBehaviour
{
	GameObject forOffGameObject;


	public void TransparentOff()
	{
		// swich off transparent before TakeAShot;
		forOffGameObject.GetComponent<Image>().color = new Color(0f, 0f, 0f, 0f);
	}
}
