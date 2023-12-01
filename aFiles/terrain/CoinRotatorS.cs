using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotatorS : MonoBehaviour
{
    float _angle;
    private void Awake()
    {
        _angle = 250f;
    }
    void Update()
    {
        float withDt = _angle * Time.deltaTime;
        transform.Rotate(withDt, withDt, 0f);
    }
}
