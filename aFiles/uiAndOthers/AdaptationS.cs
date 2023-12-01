using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdaptationS : MonoBehaviour
{
    private void Awake()
    {
        float targetAspect = 2.1641f; //iphone12
        float aspectW = (float)Screen.height / (float)Screen.width;
        float koef = aspectW / targetAspect;
        Camera.main.fieldOfView = Camera.main.fieldOfView * koef;
        if (!Application.isEditor)
        {
            Application.targetFrameRate = 65;
        }
    }

}
