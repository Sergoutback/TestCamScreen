using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using static NativeGallery;

public class ScreenShot : MonoBehaviour
{
    public GameObject UI;
    public static Texture2D texture;
    public RawImage screenShot;

    //void Start()
    //{

    //}

    //void Update()
    //{

    //}


    private IEnumerator Screenshot()
    {
        yield return new WaitForEndOfFrame();
        Texture2D texture = new Texture2D(Screen.width / 2, Screen.height / 3, TextureFormat.RGB24, false);

        texture.ReadPixels(new Rect(Screen.width / 4, Screen.height / 2, Screen.width / 2, Screen.height / 3), 0, 0);
        texture.Apply();
        
        string name = "Screenshot_YouAreBeauty_" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";

        //PC
        //byte[] bytes = texture.EncodeToPNG();
        //File.WriteAllBytes(Application.dataPath + "/../" + name, bytes);
        //Android
        NativeGallery.SaveImageToGallery(texture, "MyScreenshotPic", name);

        Destroy(texture);
        UI.SetActive(false);
    }

    public void TakeScreenshot()
    {
        UI.SetActive(false);
        StartCoroutine("Screenshot");
        PickImage(800);
    }

    public void PickImage(int maxSize)
    {
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
        {
        Debug.Log("Image path: " + path);
            if (path != null)
            {
                // Create Texture from selected image
                Texture2D texture = NativeGallery.LoadImageAtPath(path, maxSize);
                if (texture == null)
                {
                    Debug.Log("Couldn't load texture from " + path);
                    return;
                }
            }
        });
        Debug.Log("Permission result: " + permission);
    } 	
}






            //public void PickImage()
            //{
            //    SpriteRenderer.imageFromGallery = NativeGallery.GetImageFromGallery(MediaPickCallback callback, "Screenshot", "image/*");
            //}


            //SpriteRenderer.sprite = Sprite.Create(NativeGallery.LoadImageAtPath(string imagePath));



            //public static void PickImage()
            //{
            //    RenderTexture.active = LoadImageFromFile(NativeGallery.texture);
            //    //public static event System.Action<Texture2D, string> OnImagePicked;
            //}





            //public static Texture2D LoadTexture2D(string path)
            //{
            //    if (!File.Exists(path)) return null;
            //    byte[] data = File.ReadAllBytes(path);
            //    Texture2D result = new Texture2D(2, 2);
            //    result.LoadImage(data);
            //    return result;
            //}

            //public static Sprite LoadSprite(string path)
            //{
            //    if (!File.Exists(path)) return null;
            //    byte[] data = File.ReadAllBytes(path);
            //    Texture2D texture = new Texture2D(2, 2);
            //    texture.LoadImage(data);
            //    return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100);
            //}




            //// Load the image
            //texture.LoadImage(data);

            //// Create a sprite
            //Sprite screenshotSprite = Sprite.Create(screenshotTexture, new Rect(0, 0, Screen.width, Screen.height), new Vector2(0.5f, 0.5f));

            //// Set the sprite to the screenshotPreview
            //screenshotPreview.GetComponent<Image>().sprite = screenshotSprite;