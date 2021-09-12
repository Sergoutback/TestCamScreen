using System.Collections;
using System.IO;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{
    public GameObject UI;


    void Start()
    {

    }

    void Update()
    {

    }


    private IEnumerator Screenshot()
    {
        yield return new WaitForEndOfFrame();
        Texture2D texture = new Texture2D(Screen.width / 2, Screen.height / 2, TextureFormat.RGB24, false);

        texture.ReadPixels(new Rect(Screen.width / 4, Screen.height / 3, Screen.width / 2, Screen.height / 2), 0, 0);
        texture.Apply();
        
        string name = "Screenshot_YouAreBeauty" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";

        //PC
        //byte[] bytes = texture.EncodeToPNG();
        //File.WriteAllBytes(Application.dataPath + "/../" + name, bytes);
        NativeGallery.SaveImageToGallery(texture, "MyScreenshotPic", name);

        Destroy(texture);
        UI.SetActive(false);
    }

    public void TakeScreenshot()
    {
        UI.SetActive(false);
        StartCoroutine("Screenshot");
    }
}