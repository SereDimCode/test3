using AppsFlyerSDK;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinRecorderS : MonoBehaviour
{
    public int curCoins;
    public Action<int> coinGained;
    public void GainCoin()
    {
        //=========================================================== In af sdk
        Dictionary<string, string> eventData = new Dictionary<string, string>();
        eventData.Add("eventName", "ButtonClicked");
        AppsFlyer.sendEvent("af_click", eventData);
        //=========================================================== In af sdk
        curCoins++;
        coinGained?.Invoke(curCoins);
    }
}
