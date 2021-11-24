using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class simplecamera : MonoBehaviour
{
static WebCamTexture backCam;

void Start()
{
WebCamDevice[] devices = WebCamTexture.devices;
if(backCam == null)
{
backCam = new WebCamTexture();
}
GetComponent<RawImage>().texture = backCam;
backCam.Play();
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
