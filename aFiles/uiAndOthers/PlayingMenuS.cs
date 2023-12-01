using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayingMenuS : MonoBehaviour
{
    //=========================================================== Editor
    public MenuS menuS;
    public TextMeshProUGUI record;
    public CoinRecorderS coinRecorder;
    //=========================================================== Editor
    private void Awake()
    {
        coinRecorder.coinGained += CheckRecord;
    }
    public void StopGame()
    {
        menuS.pauseMenu.Show();
    }
    public void ExitGame()
    {
        Application.Quit(); //unplayable in editor
    }
    public void CheckRecord(int newAmount)
    {
        record.text = newAmount.ToString();
    }
    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }

}
