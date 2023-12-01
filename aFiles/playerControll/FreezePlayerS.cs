using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePlayerS : MonoBehaviour
{
    Vector3 _startPosition;
    private void Awake()
    {
        _startPosition = transform.position;
    }
    private void FixedUpdate()
    {
        transform.position = new Vector3 (_startPosition.x,
            transform.position.y,
            _startPosition.z);
    }
}
