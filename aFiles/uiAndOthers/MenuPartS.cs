using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPartS : MonoBehaviour
{
    //=========================================================== Editor
    public GameObject blur;
    //=========================================================== Editor
    public void Show()
    {
        Time.timeScale = 0f;
        blur.SetActive(true);
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        blur.SetActive(false);
        gameObject.SetActive(false);
    }
}
