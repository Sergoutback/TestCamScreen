using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeScreenshot : MonoBehaviour
{

	[SerializeField]
	GameObject blink;

	[SerializeField]
	GameObject panel;
	//GameObject LoadScene0Button;
	//GameObject LoadGalleryButton;
	//GameObject ScreenshotButton;


	public void TakeAShot()
	{
		StartCoroutine("CaptureIt");
	}

	IEnumerator CaptureIt()
	{
		string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
		string fileName = "Screenshot" + timeStamp + ".png";
		string pathToSave = fileName;
		ScreenCapture.CaptureScreenshot(pathToSave);
		yield return new WaitForEndOfFrame();
		Instantiate(blink, new Vector2(0f, 0f), Quaternion.identity);
	}


	public void SwitchOffTransparent()
	{
		// swich off transparent before TakeAShot;
		panel.GetComponent<Image>().color = new Color(0f, 0f, 0f, 0f);
	}
}