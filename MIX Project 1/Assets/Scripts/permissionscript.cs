using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class permissionscript : MonoBehaviour
{
    // Start is called before the first frame update
   GameObject dialog = null;
   void Start()
   {
	   
   #if PLATFORM_ANDROID
   if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
   {
	   
   Permission.RequestUserPermission(Permission.Camera);
   }
   
   #endif
   }
   
    void Update()
    {
        
    }
}
