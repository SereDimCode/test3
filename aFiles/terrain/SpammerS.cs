using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpammerS : MonoBehaviour
{
    //=========================================================== Editor
    public GameObject enemyPref;
    public GameObject coinPref;
    //=========================================================== Editor
    private void Awake()
    {
        StartCoroutine(creatingEnemies());
    }
    IEnumerator creatingEnemies()
    {
        while (true)
        {
            float rand = Random.Range(1f, 2.5f);
            int randType = Random.Range(0, 2);
            if (randType == 0)
            {
                Instantiate(enemyPref, transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(coinPref, transform.position, Quaternion.identity);
            }
            yield return new WaitForSeconds(rand);
            yield return null;
        }
    }
}
