using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class StartMenuS : MonoBehaviour
{
    public MenuS menu;
    public void StartGame()
    {
        menu.startMenu.Hide();
        menu.playingMenu.Show();
        Time.timeScale = 1f;
    }
}
