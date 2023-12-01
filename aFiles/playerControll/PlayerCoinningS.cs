using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoinningS : MonoBehaviour
{
    public CoinRecorderS coinRecorder;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            coinRecorder.GainCoin();
            Destroy(other.gameObject);
        }
    }
}
