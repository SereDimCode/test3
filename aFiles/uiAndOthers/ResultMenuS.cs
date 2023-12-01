using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultMenuS : MonoBehaviour
{
    //=========================================================== Editor
    public TextMeshProUGUI record;
    public MenuPartS menuPart;
    public CoinRecorderS coinRecorder;
    //=========================================================== Editor
    public void ShowResult()
    {
        menuPart.Show();
        record.text = coinRecorder.curCoins.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
