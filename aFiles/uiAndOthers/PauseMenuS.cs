using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuS : MonoBehaviour
{
    public MenuPartS menuPart;
    public void Resume()
    {
        menuPart.Hide();
        Time.timeScale  = 1f;
    }
}
