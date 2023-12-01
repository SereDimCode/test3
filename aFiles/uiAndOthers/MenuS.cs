using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuS : MonoBehaviour
{
    //=========================================================== Editor
    public MenuPartS startMenu;
    public MenuPartS resultMenu;
    public MenuPartS pauseMenu;
    public PlayingMenuS playingMenu;
    //=========================================================== Editor
    float targetAspect;
    void Awake()
    {
        targetAspect = 0.462f; //iphone12
        Adapt();
        MenusAtStart();
    }
    void Adapt()
    {
        float aspect = (float)Screen.width / (float)Screen.height;

        if (aspect < targetAspect)
        {
            gameObject.GetComponent<CanvasScaler>().matchWidthOrHeight = 0;
        }
    }
    void MenusAtStart()
    {
        resultMenu.Hide();
        pauseMenu.Hide();
        startMenu.Show();
        playingMenu.Show();
    }
}

