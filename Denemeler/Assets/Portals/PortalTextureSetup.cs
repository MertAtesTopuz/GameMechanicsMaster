using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{
    public Camera cameraBlue;
    public Material cameraMatBlue;

    public Camera cameraGreen;
    public Material cameraMatGreen;

    void Start()
    {
        if (cameraBlue.targetTexture != null)
        {
            cameraBlue.targetTexture.Release();
        }

        cameraBlue.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatBlue.mainTexture = cameraBlue.targetTexture;

        if (cameraGreen.targetTexture != null)
        {
            cameraGreen.targetTexture.Release();
        }

        cameraGreen.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatGreen.mainTexture = cameraGreen.targetTexture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
